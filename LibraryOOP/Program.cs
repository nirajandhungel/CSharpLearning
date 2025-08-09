using System;
public class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book("Rich Dad Poor Dad", "BOOK876543");
        book1.DisplayInfo();
        book1.CalculateLateFee(5);
        book1.BorrowItem("Nirajan");
        book1.ReturnItem();

        Magazine mz1 = new Magazine("Business Figure", "MGZ987656");
        mz1.DisplayInfo();
        mz1.CalculateLateFee(7);
        mz1.BorrowItem("Subash Dhungel");
        mz1.ReturnItem();

        DVD dvd1 = new DVD("BORN", "DVD67854");
        dvd1.DisplayInfo();
        dvd1.CalculateLateFee(3);
        dvd1.BorrowItem("Nirajan Dhungel");
        dvd1.ReturnItem();

    }
}
public interface IBorrowAble
{
    void BorrowItem(string borrower);
    void ReturnItem();
}

public abstract class LibraryItem
{
    public string Title { get; private set; }
    public string ItemId { get; private set; }
    public bool IsBorrowed { get; protected set; } = false;

    public LibraryItem(string title, string itemId)
    {
        this.Title = title;
        this.ItemId = itemId;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"The id: {ItemId} of {Title} {(IsBorrowed ? "has been borrowed" : "has not been borrowed")}");
    }

    public abstract void CalculateLateFee(int daysLate);

}

// concrete classes 

public class Book : LibraryItem, IBorrowAble
{
    private int _lateFeePerDay = 10;
    public Book(string title, string itemId) : base(title, itemId) { }

    public override void CalculateLateFee(int daysLate)
    {
        Console.WriteLine($"The total late fee of book {Title} is : {daysLate * _lateFeePerDay}");
    }

    public void BorrowItem(string borrower)
    {
        IsBorrowed = true;
        Console.WriteLine($"The {Title} book has been borrowed by {borrower}");
        
    }
    public void ReturnItem()
    {
        IsBorrowed = false;
        Console.WriteLine($"The {Title} book is set to available");
        
    }

}

public class Magazine : LibraryItem, IBorrowAble
{
    private int _lateFeePerDay = 5;
    public Magazine(string title, string itemId) : base(title, itemId) { }

    public override void CalculateLateFee(int daysLate)
    {
        Console.WriteLine($"The total late fee of magazine {Title} is : {daysLate * _lateFeePerDay}");
    }

    public void BorrowItem(string borrower)
    {
        IsBorrowed = true;
        Console.WriteLine($"The magazine {Title} has been borrowed by {borrower}");
        
    }
    public void ReturnItem()
    {
         IsBorrowed = false;
        Console.WriteLine($"The magazine {Title} is set to available");
        
    }

}

public class DVD : LibraryItem, IBorrowAble
{
    private int _lateFeePerDay = 20;
    public DVD(string title, string itemId) : base(title, itemId) { }

    public override void CalculateLateFee(int daysLate)
    {
        Console.WriteLine($"The total late fee of DVD {Title} is : {daysLate * _lateFeePerDay}");
    }

    public void BorrowItem(string borrower)
    {
         IsBorrowed = true;
        Console.WriteLine($"The DVD {Title} has been borrowed by {borrower}");
        
    }
    public void ReturnItem()
    {
         IsBorrowed = false;
        Console.WriteLine($"The DVD {Title} is set to available");
        
    }

}