using TelefonApp;

Okostelefon nokia = new Okostelefon();

nokia.Modell = "Nokia";

nokia.Toltottseg = -15;

Console.WriteLine(nokia.Modell + " Töltöttség: "+ nokia.Toltottseg);

Okostelefon samsung = new Okostelefon();

samsung.Modell = "Samsung";
samsung.Toltottseg = 110;

Console.WriteLine(samsung.Modell + " Töltöttség: " +  samsung.Toltottseg);