﻿
namespace Yemp.Services
{
    public interface IDialogFileService
    {
        string SaveFile();
        string[] OpenMultipleFiles();
        string OpenFile();

    }
}
