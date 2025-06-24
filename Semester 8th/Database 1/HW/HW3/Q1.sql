USE [Book-Database];
GO

Drop TABLE [User];
Drop TABLE Author;
Drop TABLE Book;
Drop TABLE Purchase_History;
Drop TABLE Wishlist;
Drop TABLE Rating;
Drop TABLE Shopping_Cart;
Drop TABLE Comment;
Drop TABLE Gift;


CREATE TABLE [User]
(
	User_ID INT PRIMARY KEY,
    First_Name VARCHAR(50),
    Last_Name VARCHAR(50),
    Phone VARCHAR(15),
    Email VARCHAR(100),
    Password VARCHAR(100)
);

CREATE TABLE Author (
    Author_ID INT PRIMARY KEY,
    First_Name VARCHAR(50),
    Last_Name VARCHAR(50)
);

CREATE TABLE Book (
    Book_ID INT PRIMARY KEY,
    Author_ID INT,
    Title VARCHAR(100),
    Type VARCHAR(50),
    Genre VARCHAR(50),
    Audio_version BIT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (Author_ID) REFERENCES Author(Author_ID)
);

CREATE TABLE Purchase_History (
    Purchase_ID INT PRIMARY KEY,
    User_ID INT,
    Book_ID INT,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Book_ID) REFERENCES Book(Book_ID)
);

CREATE TABLE Wishlist (
    Wishlist_ID INT PRIMARY KEY,
    User_ID INT,
    Book_ID INT,
    Author_ID INT,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Book_ID) REFERENCES Book(Book_ID),
    FOREIGN KEY (Author_ID) REFERENCES Author(Author_ID)
);

CREATE TABLE Rating (
    Rating_ID INT PRIMARY KEY,
    User_ID INT,
    Book_ID INT,
    Rating INT,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Book_ID) REFERENCES Book(Book_ID)
);

CREATE TABLE Shopping_Cart (
    Cart_ID INT PRIMARY KEY,
    User_ID INT,
    Book_ID INT,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Book_ID) REFERENCES Book(Book_ID)
);

CREATE TABLE Comment (
    Comment_ID INT PRIMARY KEY,
    User_ID INT,
    Book_ID INT,
    Comment_Text VARCHAR(255),
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Book_ID) REFERENCES Book(Book_ID)
);

CREATE TABLE Gift (
    Gift_ID INT PRIMARY KEY,
    Sender_User_ID INT,
    Receiver_User_ID INT,
    Book_ID INT,
    Is_Recipient_Aware BIT,
    FOREIGN KEY (Sender_User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Receiver_User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Book_ID) REFERENCES Book(Book_ID)
);
