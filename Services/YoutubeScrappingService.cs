using BlazorApp_WASM_WebScrapping_Youtube.Models;
using System.Net.Http.Json;

namespace BlazorApp_WASM_WebScrapping_Youtube.Services
{
    public class YoutubeScrappingService(HttpClient http)
    {
        private readonly HttpClient _httpClient = http;

        public async Task<List<Video>> GetVideos()
        {
            try
            {
                var req = await _httpClient.GetFromJsonAsync<List<Video>>("/api/Videos");
                return req ?? [];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener videos: {ex.Message}");
                return [];
                throw;
            }
        }
        public async Task<List<Video>> GetPupularVideos()
        {
            try
            {
                var req = await _httpClient.GetFromJsonAsync<List<Video>>("/api/Videos/PopularVideos");
                return req ?? [];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener videos: {ex.Message}");
                return [];
                throw;
            }
        }
    }
}
