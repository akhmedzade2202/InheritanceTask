using InheritanceAnimal;

Dog dog1 = new Dog("Rex", 3, "Hav-hav", "German Shepherd");
Dog dog2 = new Dog("Buddy", 2, "Vov-vov", "Labrador");

Cat cat1 = new Cat("Mimi", 1, "Miyav", "Ağ");
Cat cat2 = new Cat("Luna", 2, "Mew", "Qara");

Bird bird1 = new Bird("Kiwi", 1, "Cik-cik", 15.2);
Bird bird2 = new Bird("Sky", 2, "Tvit-tvit", 18.7);

Animal[] animals = { dog1, dog2, cat1, cat2, bird1, bird2 };

foreach (var animal in animals)
{
    animal.printInfo();
}


