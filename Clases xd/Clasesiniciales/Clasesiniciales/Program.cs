using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasesiniciales
{
    class Program
    {
        //Este es el metodo main
        //Sirve como punto de entrada
        //para el programa (inicia desde aqui)
        static void Main(string[] args)
        {
            //Esto es una instancia de mochila
            Mochila mochilaAna = new Mochila();
            mochilaAna.Disenio = "Piolin";
            mochilaAna.Material = "Vynyl";
            mochilaAna.NumeroDeBolsas = 3;
            mochilaAna.NumeroDeLlaveros = 0;
            mochilaAna.Precio = 500.00f;
            mochilaAna.color = new Color();
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Verde = 20;
            mochilaAna.color.Azul = 33;

            Mochila mochilaBeto = new Mochila();
            mochilaBeto.Disenio = "Pokemon";
            mochilaBeto.Material = "Piel";
            mochilaBeto.NumeroDeBolsas = 3;
            mochilaBeto.NumeroDeLlaveros = 3;
            mochilaBeto.Precio = 179.50f;
            mochilaBeto.color = new Color();
            mochilaBeto.color.Rojo = 0;
            mochilaBeto.color.Verde = 128;
            mochilaBeto.color.Azul = 210;

            Mochila mochilaCaro = new Mochila();
            mochilaCaro.Disenio = "MyLittePony";
            mochilaCaro.Material = "Algodon";
            mochilaCaro.NumeroDeBolsas = 1;
            mochilaCaro.NumeroDeLlaveros = 0;
            mochilaCaro.Precio = 249.50f;
            mochilaCaro.color = new Color();
            mochilaCaro.color.Rojo = 205;
            mochilaCaro.color.Verde = 76;
            mochilaCaro.color.Azul = 12;

            //Esto es una instancia de Smartphone

            Smartphone Mismartphone = new Smartphone();
            Mismartphone.NombreDelSmartphone = "Samsung Galaxy S10";
            Mismartphone.AnioLanzamiento = 2019;
            Mismartphone.body = new Body();
            Mismartphone.body.DimensionAncho = 70.4f;
            Mismartphone.body.DimensionLargo = 149.9f;
            Mismartphone.body.Material = "Glass front (Gorilla Glass 6), glass back (Gorilla Glass 5), aluminum frame";
            Mismartphone.body.SIM = "Single SIM (Nano-SIM) or Hybrid Dual SIM (Nano-SIM, dual stand-by)";
            Mismartphone.body.Weight = 157;
            Mismartphone.displaytype = "Dynamic AMOLED, HDR10+";
            Mismartphone.displaysize = 6.1f;
            Mismartphone.displayresolutionAncho = 1440;
            Mismartphone.displayresolutionLargo = 3040;
            Mismartphone.displayProtection = "Corning Gorilla Glass 6";
            Mismartphone.OS = "Android 9.0 (Pie), upgradable to Android 12, One UI 4.1";
            Mismartphone.Chipset = "Exynos 9820 (8 nm) - EMEA/LATAM";
            Mismartphone.CPU = "Octa-core (2x2.73 GHz Mongoose M4 & 2x2.31 GHz Cortex-A75 & 4x1.95 GHz";
            Mismartphone.GPU = "Mali-G76 MP12 - EMEA/LATAM";
            Mismartphone.Cardslot = "microSDXC (uses shared SIM slot)";
            Mismartphone.internalMemory = 128;
            Mismartphone.MainCameraCount = 3;
            Mismartphone.MainCameraFeatures = "LED flash, auto-HDR, panorama";
            Mismartphone.SelfieCameraCount = 1;
            Mismartphone.SelfieCameraFeatures = "Dual video call, Auto-HDR";
            Mismartphone.LoudspeakerSound = "Yes, with stereo speakers";
            Mismartphone.CommsWLAN = "Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, Wi-Fi Direct";
            Mismartphone.CommsBluetooth = "5.0, A2DP, LE, aptX";
            Mismartphone.CommsPositioning = "GPS, GLONASS, BDS, GALILEO";
            Mismartphone.CommsNFC = "Yes";
            Mismartphone.CommsRadio = "FM radio (USA & Canada only)";
            Mismartphone.CommsUSB = "USB Type-C 3.1";
            Mismartphone.featuresSensors = "Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, barometer, heart rate, SpO2";
            Mismartphone.batterytype = "Li-Ion 3400 mAh, non-removable";
            Mismartphone.MiscColor = "Prism White";
            Mismartphone.Model = "SM-G973F";
            Mismartphone.PriceInEUR =300.00f;
    }
    }
}
