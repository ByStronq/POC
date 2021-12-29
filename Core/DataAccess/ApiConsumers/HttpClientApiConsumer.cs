using Core.Entities;
using Core.Utilities.Results;
using System.Net.Http.Json;
using System.Text.Json;

namespace Core.DataAccess.ApiConsumers
{
    public class HttpClientApiConsumer<TEntity> : IApiConsumer<TEntity>
        where TEntity : class, IEntity, new()
    {
        public Uri BaseAddress { get; set; }

        private readonly HttpClientHandler clientHandler;

        public HttpClientApiConsumer()
        {
            BaseAddress = new Uri($"https://localhost:7202/api/{typeof(TEntity).Name}s/");
            clientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };
        }

        public async Task<IResult?> Add(TEntity entity)
        {
            using var client = new HttpClient(clientHandler);

            client.BaseAddress = BaseAddress;

            var response = await client
                .PostAsync(
                    new Uri("Add", UriKind.Relative),
                    JsonContent.Create(entity)
                );

            using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync
                    <SuccessResult>(responseStream);
        }

        public async Task<IResult?> Update(TEntity entity)
        {
            using var client = new HttpClient(clientHandler);

            client.BaseAddress = BaseAddress;

            var response = await client
                .PutAsync(
                    new Uri("Update", UriKind.Relative),
                    JsonContent.Create(entity)
                );

            using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync
                    <SuccessResult>(responseStream);
        }

        public async Task<IResult?> Delete(int entityId)
        {
            using var client = new HttpClient(clientHandler);

            client.BaseAddress = BaseAddress;

            var response = await client
                .DeleteAsync(
                    new Uri("Delete", UriKind.Relative)
                );

            using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync
                    <SuccessResult>(responseStream);
        }

        public async Task<IDataResult<TEntity>?> Get(int entityId)
        {
            using var client = new HttpClient(clientHandler);

            client.BaseAddress = BaseAddress;

            var response = await client
                .GetAsync(
                    new Uri($"Get/{entityId}", UriKind.Relative)
                );

            using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync
                    <SuccessDataResult<TEntity>>(responseStream);
        }

        public async Task<IDataResult<TEntity>?> GetWithDetails(int entityId)
        {
            using var client = new HttpClient(clientHandler);

            client.BaseAddress = BaseAddress;

            var response = await client
                .GetAsync(
                    new Uri($"GetWithDetails/{entityId}", UriKind.Relative)
                );

            using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync
                    <SuccessDataResult<TEntity>>(responseStream);
        }

        public async Task<IDataResult<IEnumerable<TEntity>>?> GetAll()
        {
            using var client = new HttpClient(clientHandler);

            client.BaseAddress = BaseAddress;

            var response = await client
                .GetAsync(
                    new Uri("GetAll", UriKind.Relative)
                );

            using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync
                    <SuccessDataResult<IEnumerable<TEntity>>>(responseStream);
        }

        public async Task<IDataResult<IEnumerable<TEntity>>?> GetAllWithDetails()
        {
            using var client = new HttpClient(clientHandler);

            client.BaseAddress = BaseAddress;
                
            var response = await client
                .GetAsync(
                    new Uri("GetAllWithDetails", UriKind.Relative)
                );

            using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync
                    <SuccessDataResult<IEnumerable<TEntity>>>(responseStream);
        }
    }
}
