public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize to 0

    public ExampleClass() { //Constructor
        MyProperty = 10; //Initalize in Constructor
    }

    public void MyMethod()
    {
        // The NullReferenceException is avoided because MyProperty is initialized.
        int value = MyProperty * 2; 
    }
}

//Alternatively
public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        if(MyProperty != null){
            int value = MyProperty * 2; 
        } else{
             //Handle null case
        }
    }
} 