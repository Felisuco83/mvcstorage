using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;

namespace MvcStorage.Services
{
    public class ServiceStorageFile
    {
        private ShareDirectoryClient root;

        public ServiceStorageFile(String keys)
        {
            ShareClient client = 
                new ShareClient(keys, "ejemplo");
            this.root = client.GetRootDirectoryClient();
        }

        public async Task<List<String>> GetFilesAsync()
        {
            List<String> files = new List<string>();
            await foreach (var file in this.root.GetFilesAndDirectoriesAsync())
            {
                files.Add(file.Name);
            }
            return files;
        }

        public async Task<String> GetFileContentAsync(String filename)
        {
            ShareFileClient file = this.root.GetFileClient(filename);
            var data = await file.DownloadAsync();
            Stream stream = data.Value.Content;
            StreamReader reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }

        public async Task DeleteFileAsync(String filename)
        {
            ShareFileClient file = this.root.GetFileClient(filename);
            await file.DeleteAsync();
        }

        public async Task UploadFileAsync(String filename
            , Stream stream)
        {
            ShareFileClient file = this.root.GetFileClient(filename);
            await file.CreateAsync(stream.Length);
            await file.UploadAsync(stream);
        }
    }
}
