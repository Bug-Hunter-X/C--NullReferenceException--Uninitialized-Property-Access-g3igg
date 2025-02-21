public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // This line might throw a NullReferenceException if MyProperty is not initialized.
        int value = MyProperty * 2; 
    }
}