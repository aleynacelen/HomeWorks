using System;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Services.Abstract;

public interface IOrderServices
{
    Task<ResponseDto<OrderDto>> GetOrderByIdAsync(int orderId); 
    Task<ResponseDto<IEnumerable<OrderDto>>> GetOrdersByUserAsync(int userId); 
    Task<ResponseDto<OrderDto>> CreateOrderAsync(OrderCreateDto orderCreateDto); // yeni bir sipariş oluştur
    Task<ResponseDto<NoContent>> UpdateOrderStatusAsync(int orderId, string newStatus); 
    Task<ResponseDto<NoContent>> CancelOrderAsync(int orderId); //iptal
    Task<ResponseDto<IEnumerable<OrderDto>>> GetAllOrdersAsync(); //tüm siparişler
    Task<ResponseDto<int>> GetOrderCountAsync(int userId); //kullanıcının toplam sipariş sayısı
  

}
