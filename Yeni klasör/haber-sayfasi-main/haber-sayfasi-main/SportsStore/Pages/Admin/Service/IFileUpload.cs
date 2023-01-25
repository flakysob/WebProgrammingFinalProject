using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Pages.Admin.Service
{
    public interface IFileUpload
    {
        Task UploadAsync(BlazorInputFile.IFileListEntry file);
    }
}
