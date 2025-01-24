using System;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Services.Abstract;

public interface ICartSevices
{
    Task<ResponseDto<CartDto>> GetCartAsync(int userId); //kullanıcının sepetini getir
    Task<ResponseDto<NoContent>> AddToCartAsync(int userId, CartItemCreateDto cartItemCreateDto); //sepete ürün ekle
    Task<ResponseDto<NoContent>> UpdateCartItemAsync(int userId, CartItemUpdateDto cartItemUpdateDto); // sepetteki bir ürünü güncelle
    Task<ResponseDto<NoContent>> RemoveFromCartAsync(int userId, int productId); // sepetten bir ürünü çıkar
    Task<ResponseDto<NoContent>> ClearCartAsync(int userId); // sepeti tamamen temizle
    Task<ResponseDto<decimal>> GetTotalPriceAsync(int userId); // sepetin toplam tutarını getir
    Task<ResponseDto<int>> GetItemCountAsync(int userId); // sepetteki toplam ürün sayısını getir
    Task<ResponseDto<bool>> CheckoutAsync(int userId); // kullanıcının sepetini siparişe dönüştür

}
