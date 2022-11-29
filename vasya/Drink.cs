internal class Drink{ // класс для выпивки. пожалуй, его объектом будет одна порция.
    double volume;   // Объем
    int strength;   // Крепость

    public Drink(double volume, int strength)
    {
        this.volume = volume;  // объем
        if (strength >= 0 && strength <= 96.2){  // все мы понимаем, что спирт создаёт с водой неразрывно-кипящую смесь при 96.2%
        this.strength = strength;   // значит крепость всегда будет меньше, но не ниже 0, т.к. кислоту люди в этой программе
        // пить не будут ... пока.
        }
    }

    public double Volume {
        get {
            return volume;
        }
        set {
            if (!(value < 0)){
                volume = value;
            } else {
                volume = 0;
            }
        }
    }
    public double Strength{
        get {
            return strength;
        }
    }
}