// пусть Вася будет существующим типом данных 
// Для ленивых есть удобное расширение C# Extensions v1.7.3, после его установки появляются 
// дополнительные менюшки С#, в т.ч. для создания классов))

internal class Human    // создан класс человек (очень похоже на обычный метод)
{
    // аналогично другим переменным классу определяются свойства
    int age;   // возраст
    //свойства класса в большинстве случаев имеют явно обозначенную безопасность:
    public string name;   // имя можно будет изменить напрямую после создания объекта.
    // такой подход нежелателен.
    protected double weight;  // вес можно будет изменить при использовании класса внутри его программы.
    // уже лучше, но придется расчитывать на адекватность других людей. 
    private int health;  // оптимальный вариант для инкапсуляции: здоровье не подвергается угрозе из вне
    private double sobriety; 

    public Human(string name, int age, double weight)   // это конструктор класса.
    // он публичный, для того, чтоб пользователь мог создать нужного человека
    // для создания объекта этого класса нужно будет воспользоваться принципом:
    //  Human vasya = new Human("Вася", 35, 90);
    // где, vasya - название объекта в программе, 35 - возраст, 90 - вес, Вася - имя, если что.
    {
        this.name = name;   
        this.age = age;
        this.weight = weight;
        // проще говоря: имя, возраст и вес этого, как его, будут такими, как скажет пользователь
        this.health = 100;
        this.sobriety = 100;
        // а здоровье и трезвость этого (зоздаваемого) будут по соточке при создании.
    }
    // но вечно трезвым человек, Вася, например, быть не может, 
    // поэтому придется что-то придумывать
    // для каждого свойства, которое будет изменяться нужно задать т.н. геттер и сеттер.
    // в C# это происходит следующим образом:
    public double Sobriety {   // не знаю даже, как комментировать такой синтаксис
        get {   // геттер используется для получения значения
            return sobriety;   // для получения значения все довольно просто
            // при работе с объектом мы запросим vasya.Sobriety и получим значение
        }
        set {  // сеттер используется для присвоения значения.
        // мы пишем vasya.Sobriety = 95 и это 95 превращается в переменную value внутри этого метода.
        // здесь же формируются условия для его применения
            if (!(value>100 || value<0)){  // например, уточняем, что трезвость человека не может быть свыше 100%
            // или меньше 0
            sobriety = value;   // если всё верно - соглашаемся на пользовательское условие
            } // если на этом завершить метод - он будет работать просто игнорируя неверные значения
            // можно добавить элсы, или другие условия.
        }
    }
    public int Health {
        get {
            return health;   // получение уровня здоровья
        }
        set {  // настройка здоровья
            if (value > 0 && value < 100){
            health = value;
            }  // я хотел добавить условие, на случай падения здоровья ниже 0, но решил оставить будущих персонажей бессмертными)
        }
    }

    //кроме свойств объекты могут иметь свои функции.
    private void Say (string text){     // у человека при потере трезвости нарушается четкость и последовательность речи
        if (this.sobriety > 70){
            Console.WriteLine(text);
        } else if (this.sobriety > 40){
            text = text.Substring(1, text.Length - 2);   // метод .Substring может обрезать строки
            Console.WriteLine($"Э{text} ну...");
        } else {
            string text1 = text.Substring(4, text.Length - 2);
            string text2 = text.Substring(0, text.Length-3);
            Console.WriteLine($"Э{text1} это... {text2}мъ");
        }
    }

    private void ToDrink (Drink anyDrink, double volume){ // 

    }

    // Думаю, я смог донести основные принципы. Параметры могут зависить друг от друга на любых условиях.
    // всё, что происходит внутри этого класса - магия для всех остальных. Особенно, при модификаторе доступа private
}