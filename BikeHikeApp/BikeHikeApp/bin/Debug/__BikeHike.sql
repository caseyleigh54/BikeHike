CREATE TABLE Customers (
  CID        INT IDENTITY(20001,1) PRIMARY  KEY,
  FirstName  NVARCHAR(64) NOT NULL,
  LastName   NVARCHAR(64) NOT NULL,
  Email      NVARCHAR(64) NOT NULL
);

CREATE TABLE BikeTypes (  
  TID           INT IDENTITY(1,1) PRIMARY KEY, 
  Description   NVARCHAR(64) NOT NULL,
  PricePerHour  MONEY NOT NULL
);

CREATE TABLE Bikes (
  BID     INT IDENTITY(1001,1) PRIMARY KEY,
  TID     INT NOT NULL FOREIGN KEY REFERENCES BikeTypes(TID),
  Year    SMALLINT NOT NULL,
  Rented  BIT NOT NULL -- 0 not rented, 1 rented
);

CREATE TABLE Rentals ( 
  RID          INT IDENTITY(1, 1) PRIMARY KEY,
  CID          INT NOT NULL FOREIGN KEY REFERENCES Customers(CID), 
  StartTime    DATETIME NOT NULL, 
  ExpDuration  FLOAT NOT NULL,
  NumBikes     SMALLINT NOT NULL,
  ActDuration  FLOAT, -- can be NULL, meaning rental in progress
  TotalPrice   MONEY  -- can be NULL, meaning rental in progress
);

CREATE TABLE RentalDetails (
  RDID  INT IDENTITY(1, 1) PRIMARY KEY,
  RID   INT NOT NULL FOREIGN KEY REFERENCES Rentals(RID),
  BID   INT NOT NULL FOREIGN KEY REFERENCES Bikes(BID)
);



