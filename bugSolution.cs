public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass()  // Constructor to initialize MyProperty
    {
        MyProperty = 0; // Initialize with default or another suitable value
    }
    public void MyMethod()
    {
        int value = MyProperty; // Now MyProperty is initialized 
    }
}