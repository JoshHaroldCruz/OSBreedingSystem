using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using OSBreedingSystem.Models;
using OSBreedingSystem.Models.DTOs;

namespace OSBreedingSystem.Services
{
    public class PetService
    {
        private readonly HttpClient _httpClient;

        public PetService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Fetch all pets
        //public async Task<List<Pet>> GetPetsAsync()
        //{
        //    return await _httpClient.GetFromJsonAsync<List<Pet>>("pets");
        //}

        public async Task<List<PetDto>> GetPetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<PetDto>>("pets");
        }


        // Fetch pet by ID
        public async Task<Pet> GetPetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Pet>($"pets/{id}");
        }

        // Add a new pet
        public async Task<bool> AddPetAsync(PetCreateDto newPet)
        {
            var response = await _httpClient.PostAsJsonAsync("pets", newPet);
            return response.IsSuccessStatusCode;
        }

        // Update pet
        public async Task<bool> UpdatePetAsync(int id, Pet updatedPet)
        {
            var response = await _httpClient.PutAsJsonAsync($"pets/{id}", updatedPet);
            return response.IsSuccessStatusCode;
        }

        // Delete pet
        public async Task<bool> DeletePetAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"pets/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<BreedDto>> GetBreedsBySpeciesAsync(int speciesId)
        {
            Console.WriteLine($"Calling API: api/Breeds/bySpecies/{speciesId}");

            var breeds = await _httpClient.GetFromJsonAsync<List<BreedDto>>($"api/Breeds/bySpecies/{speciesId}");

            Console.WriteLine($"Received {breeds?.Count} breeds from API.");
            return breeds ?? new List<BreedDto>();
        }
    }
}
