using Adapter;

Android android = new Android();
Iphone iPhone = new Iphone();
Console.WriteLine("Recharging android with MicroUsb");
rechargeMicroUsbPhone(android);
Console.WriteLine("Recharging iPhone with Lightning");
rechargeLightningPhone(iPhone);
Console.WriteLine("Recharging iPhone with MicroUsb");
rechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iPhone)
static void rechargeMicroUsbPhone(MicroUsbPhone phone)
{
    phone.useMicroUsb();
    phone.recharge();
}
static void rechargeLightningPhone(LightningPhone phone)
{
    phone.useLightning();
    phone.recharge();
}