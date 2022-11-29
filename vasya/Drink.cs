internal class Drink{ // класс для выпивки. пожалуй, его объектом будет одна порция.
    double volume;   // Объем
    int strength;   // Крепость

    public Drink(double volume, int strength)
    {
        this.volume = volume;
        if (strength >= 0 && strength <= 96.2){
        this.strength = strength;}
    }
}