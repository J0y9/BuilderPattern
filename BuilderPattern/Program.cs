using BuilderPattern;

var customPcBuilder = new CustomPcBuilder();
customPcBuilder.SetCpu("I5-10500K");
customPcBuilder.SetGpu("RTX 3060TI");
customPcBuilder.SetMotherBoard("ASUS ROG B500x");
customPcBuilder.SetRam("32GB 3600MHZ");
Pc customPc = customPcBuilder.Build();
customPc.Show();

PcShop myShop = new PcShop();
Pc lowEndPc = myShop.BuildPc(new LowEndPcBuilder());