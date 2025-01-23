using System;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Services.Abstract;

public interface IProductServices
{
    Task<ResponseDto<ProductDto>> GetAsync(int id); //ide göre ürünün bilgisini getirir
    Task<ResponseDto<IEnumerable<ProductDto>>> GetAllAsync(); // tüm ürünleri getirir
    Task<ResponseDto<IEnumerable<ProductDto>>> GetAllAsync(bool? isActive); //aktif veya pasif olan ürünleri getirir
    Task<ResponseDto<ProductDto>> AddAsync(ProductCreateDto productCreateDto); //yeni bir ürün ekleriz
    Task<ResponseDto<NoContent>> UpdateAsync(ProductUpdateDto productUpdateDto); // ürünü güncelleri<
    Task<ResponseDto<NoContent>> SoftDeleteAsync(int id); // ürünü geçici sileriz
       Task<ResponseDto<NoContent>> HardDeleteAsync(int id); // Ürünü tamamen sil
    Task<ResponseDto<int>> CountAsync(); //total ürün sayısını döndür
    Task<ResponseDto<int>> CountAsync(bool? isActive); //aktif ürün sayısını döndür
    Task<ResponseDto<bool>> UpdateIsActiveAsync(int id); // aktifmi pasifmi güncelleriz

    
     Task<ResponseDto<IEnumerable<ProductDto>>> GetByCategoryIdAsync(int categoryId);//belirli bir kategoriye ait olan ürünleri getiririz
    Task<ResponseDto<IEnumerable<ProductDto>>> SearchAsync(string keyword); // Ürünleri isim veya açıklamaya göre ara
    Task<ResponseDto<IEnumerable<ProductDto>>> GetFeaturedProductsAsync(); // Öne çıkan ürünleri getir
    Task<ResponseDto<decimal>> GetTotalStockValueAsync(); // Stokta bulunan tüm ürünlerin toplam değerini döndür

}
