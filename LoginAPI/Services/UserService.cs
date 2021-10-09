using LoginAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Services
{
    public class UserService
    {
        private readonly UserContext _context;
        private readonly ITokenService _tokenService;

        public UserService(UserContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public UserDTO Register(UserDTO userDTO)
        {
            try
            {
                using var hmac = new HMACSHA512();
                var user = new User()
                {
                    UserId = userDTO.id,

                    Name = userDTO.Name,
                    Address = userDTO.Address,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password)),
                    PasswordSalt = hmac.Key

                };

                _context.Users.Add(user);
                _context.SaveChanges();
                userDTO.jwtToken = _tokenService.CreateToken(userDTO);
                userDTO.Password = "";
                return userDTO;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }
        public UserDTO Login(UserDTO userDTO)
        {
            try
            {
                var myUser = _context.Users.SingleOrDefault(u => u.UserId == userDTO.id);
                if (myUser != null)
                {
                    using var hmac = new HMACSHA512(myUser.PasswordSalt);
                    var userPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));

                    for (int i = 0; i < userPassword.Length; i++)
                    {
                        if (userPassword[i] != myUser.PasswordHash[i])
                            return null;
                    }
                    userDTO.jwtToken = _tokenService.CreateToken(userDTO);
                    userDTO.Password = "";
                    return userDTO;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }

        public ICollection<User> GetAll()
        {
            IList<User> user = _context.Users.ToList();
            if (user.Count > 0)

                return user;
            else
                return null;



        }
        public User Get(int id) 
        {
            User user = null;
             user = _context.Users.FirstOrDefault(p => p.UserId == "id");
                return user;
            
        }

        public OrderDTO Orders (OrderDTO  orderDtO)
        {
            OrderDTO ordersDTO = null;
          
            using (var client = new HttpClient())
            {
                //var OrderDetailsDTO  = new OrderDetailsDTO()
                //{
                //    OrderId = orderDtO.OrderID,



                //};
                //_context.orderDetails.Add(OrderDetailsDTO);
                //_context.SaveChanges();

                client.BaseAddress = new Uri("http://localhost:12834/api/");
                var postTask = client.PostAsJsonAsync<OrderDTO>("Order", orderDtO);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadFromJsonAsync<OrderDTO>();
                    data.Wait();
                    ordersDTO = data.Result;



                }

            }
            return ordersDTO;
        }

        //public OrderDTO GetOrder(int id)
        //{
        //    OrderDTO ord = null;
        //    ord = _context.ordDetail.FirstOrDefault(e => e.OrderID == id);
        //    return ord;

        //}


        public OrderDetailsDTO Orderdetail(OrderDetailsDTO orderdetDtO)
        {
            OrderDetailsDTO ordersDTO = null;
           
            using (var client = new HttpClient())
            {
               

                client.BaseAddress = new Uri("http://localhost:24368/api/");
                var postTask = client.PostAsJsonAsync<OrderDetailsDTO>("OrderDetails", orderdetDtO);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadFromJsonAsync<OrderDetailsDTO>();
                    data.Wait();
                    ordersDTO = data.Result;



                }

            }
            return ordersDTO;
        }


        public ToppingDTO ToppingDetail(ToppingDTO toppingDtO)
        {
            ToppingDTO topDTO = null;

            using (var client = new HttpClient())
            {


                client.BaseAddress = new Uri("http://localhost:15458/api/");
                var postTask = client.PostAsJsonAsync<ToppingDTO>("Toppings", toppingDtO);
              
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadFromJsonAsync<ToppingDTO>();
                    data.Wait();
                    topDTO = data.Result;



                }

            }
            return topDTO;
        }

       




    }
}
