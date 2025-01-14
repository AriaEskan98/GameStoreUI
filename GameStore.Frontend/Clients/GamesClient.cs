﻿using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients
{
    public class GamesClient(HttpClient httpClient)
    {
        public async Task<GameSummary[]> GetGamesAsync()
            => await httpClient.GetFromJsonAsync<GameSummary[]>("games") ?? [];
    
        public async Task AddGameAsync(GameDetails game)
            => await httpClient.PostAsJsonAsync("games", game);



        public async Task<GameDetails> FindGameAsync(int id)
            => await httpClient.GetFromJsonAsync<GameDetails>($"games/{id}") ??
            throw new Exception("Could not find game!");

        public async Task EditGameAsync(GameDetails updatedGame)
            => await httpClient.PutAsJsonAsync($"games/{updatedGame.Id}", updatedGame);

        public async Task DeleteGameAsync(int Id)
            => await httpClient.DeleteAsync($"games/{Id}");



    }
}
