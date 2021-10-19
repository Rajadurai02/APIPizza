using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaApplicationMVC.Models;
using PizzaApplicationMVC.Services;
using PizzaApplicationMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplicationMVC.Controllers
{
    public class OrderSummaryController : Controller
    {
        private readonly PizzaService _pizzaService;
        private readonly ToppingService _toppingService;
        private readonly OrderService _orderService;
        private readonly OrderDetailService _orderDetailService;
        private readonly OrderItemDetailService _orderItemDetailService;

        public OrderSummaryController(PizzaService pizzaService, ToppingService toppingService, OrderService orderService, OrderDetailService orderDetailService, OrderItemDetailService orderItemDetailService)
        {
            _pizzaService = pizzaService;
            _toppingService = toppingService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _orderItemDetailService = orderItemDetailService;
        }
        public IActionResult Index()
        {
            try
            {
                string token = (string)TempData.Peek("token");
                int OrderID = Convert.ToInt32(TempData.Peek("orderId"));
                List<OrderDetailDTO> orderdetails = _orderDetailService.AllOrder(token);
                List<OrderDetailDTO> orders = new();
                foreach (var item in orderdetails)
                {
                    if (item.OrderId == OrderID)
                    {
                        orders.Add(item);
                    }
                }
                ViewBag.ItemDetails = orders;
                // IList<PizzaDetail> pizzas = null;
                List<OrderItemDetailDTO> items = null;
                List<FinalOutputModel> obj = new();
                foreach (var item in ViewBag.ItemDetails)
                {
                    FinalOutputModel output = new();
                    output.Pizza = _pizzaService.GetPizza(item.PizzaId, token);
                    output.orderDetail = _orderDetailService.GetOrder(item.ItemId, token);
                    output.Toppings = new();
                    int pizzanumber = item.PizzaId;
                    List<OrderItemDetailDTO> orderItemdetails = _orderItemDetailService.AllOrder(token);
                    List<OrderItemDetailDTO> orderItems = new();
                    foreach (var orderitem in orderItemdetails)
                    {
                        if (orderitem.ItemId == item.ItemId)
                        {
                            orderItems.Add(orderitem);
                        }
                    }
                    items = orderItems;
                    OrderDTO order = _orderService.GetOrder(OrderID, token);
                    foreach (var itemtopping in items)
                    {

                        ToppingDTO topping = _toppingService.GetTopping(itemtopping.ToppingId, token);
                        output.Toppings.Add(topping);

                    }
                    if (order != null)
                    {
                        if (order.OrderTotal < 50)
                        {
                            order.OrderTotal += 5;
                            order.DeliveryCharge = 5;
                        }
                        else
                        {
                            order.DeliveryCharge = 0;
                        }
                        order.Status = "Confirmed";
                        _orderService.EditOrder(Convert.ToInt32(TempData.Peek("orderId")), order, token);
                    }
                   
                    OrderDTO FinalOrder = _orderService.GetOrder(OrderID, token);
                    ViewBag.theOrder = FinalOrder;
                    obj.Add(output);
                }
                // ViewBag.PizzaDetails = pizzas;
                OutputList objBind = new();
                objBind.FinalListPizzas = obj;
                return View(objBind);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }
        public IActionResult Remove(int id)
        {
            string token = (string)TempData.Peek("token");
            int DeductAmount = 0;
            OrderDetailDTO orderDetail = _orderDetailService.GetOrder(id, token);
            int itemID = orderDetail.ItemId;
            int pizzaID = orderDetail.PizzaId;
            int orderID = orderDetail.OrderId;
            List<OrderItemDetailDTO> AllItems = _orderItemDetailService.AllOrder(token);
            List<OrderItemDetailDTO> ParticularItems = new();
            foreach (var item in AllItems)
            {
                if (itemID == item.ItemId)
                {
                    ParticularItems.Add(item);
                }
            }
            PizzaDTO pizza = _pizzaService.GetPizza(pizzaID, token);
            DeductAmount += pizza.PizzaPrice;
            if (ParticularItems != null)
            {
                foreach (var toppings in ParticularItems)
                {
                    ToppingDTO topping = _toppingService.GetTopping(toppings.ToppingId, token);
                    DeductAmount += topping.ToppingPrice;
                    _orderItemDetailService.RemoveOrder(toppings.ItemId, token);
                }
            }
            OrderDTO order = _orderService.GetOrder(orderID, token);
            order.OrderTotal -= DeductAmount;
            _orderService.EditOrder(orderID, order, token);
            _orderDetailService.RemoveOrder(id, token);            
            return RedirectToAction("Index","OrderSummary");
        }
        
        public IActionResult Confirm()
        {
            return View();
        }
    }
}
