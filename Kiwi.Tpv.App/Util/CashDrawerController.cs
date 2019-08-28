using System;
using System.Runtime.InteropServices;

namespace Kiwi.Tpv.App.Util
{
    public static class CashDrawerController
    {
        private static readonly byte [] AppOpenCashDrawerCommand = {27, 112, 0, 25, 250};
        //private byte[] codeOpenCashDrawer = new byte[] { 27, 112, 48, 55, 121 };

        public static void Open()
        {
            try
            {
                var pUnmanagedBytes = Marshal.AllocCoTaskMem(5);
                Marshal.Copy(AppOpenCashDrawerCommand, 0, pUnmanagedBytes, 5);
                RawPrinterHelper.SendBytesToPrinter("EPSON TM-T20II Receipt", pUnmanagedBytes, 5);
                Marshal.FreeCoTaskMem(pUnmanagedBytes);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}