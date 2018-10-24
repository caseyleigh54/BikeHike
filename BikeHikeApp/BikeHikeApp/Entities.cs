using System;
using System.Data;

namespace BikeHikeApp
{
  class Customer
  {
    public int CID { get; private set; }
    public string LastName { get; private set; }
    public string FirstName { get; private set; }
    public string Email { get; private set; }

    public Customer(int id, string lname, string fname, string email)
    {
      CID = id;
      LastName = lname;
      FirstName = fname;
      Email = email;
    }

    public override string ToString()
    {
      return string.Format("{0}, {1}", LastName, FirstName);
    }

    //
    // Returns true if customer is out on a rental, false if not:
    //
    public bool OnRental()
    {
      return OnRental(out _, out _, out _, out _);  // ignore rental info:
    }

    public bool OnRental(out int RID,
      out DateTime start,
      out double expDuration,
      out int N)
    {
      RID = 0;
      start = DateTime.Now;
      expDuration = 0;
      N = 0;

      //
      // customer is renting if actual duration of rental is still NULL:
      //
      string sql = string.Format(@"
Select RID, StartTime, ExpDuration, NumBikes
From Rentals
Where CID = {0} AND
      ActDuration IS NULL;
",
CID);

      DataAccessTier.Data datatier = new DataAccessTier.Data("BikeHike.mdf");

      try
      {
        DataSet ds = datatier.ExecuteNonScalarQuery(sql);

        if (ds.Tables["TABLE"].Rows.Count == 0)  // not found => not on a rental:
        {
          return false;
        }

        //
        // customer is on a rental, so extract and return rental info:
        //
        DataRow row = ds.Tables["TABLE"].Rows[0];

        RID = Convert.ToInt32(row["RID"]);
        start = Convert.ToDateTime(row["StartTime"]);
        expDuration = Convert.ToDouble(row["ExpDuration"]);
        N = Convert.ToInt32(row["NumBikes"]);

        return true;  // on rental:
      }
      catch(Exception ex)
      {
        System.Diagnostics.Debug.WriteLine(ex.Message);
        return false;
      }
    }
  }//class

  class Bike
  {
    public int BID { get; private set; }
    public int Year { get; private set; }
    public string Description { get; private set; }
    public decimal PricePerHour { get; private set; }

    public Bike(int id, int year, string description, decimal priceperhour)
    {
      BID = id;
      Year = year;
      Description = description;
      PricePerHour = priceperhour;
    }

    public override string ToString()
    {
      return BID.ToString();
    }

    //
    // Returns true if bike is out on a rental, false if not:
    //
    public bool OnRental()
    {
      return OnRental(out _);  // ignore rental info:
    }

    public bool OnRental(out DateTime dueback)
    {
      dueback = DateTime.Now;

      //
      // bike is on rental based on Rented attribute:
      //
      string sql = string.Format(@"
Select Rented
From Bikes
Where BID = {0};
", BID);

      DataAccessTier.Data datatier = new DataAccessTier.Data("BikeHike.mdf");

      try
      {
        object result = datatier.ExecuteScalarQuery(sql);

        if (result == null)  // something is wrong, bike not found...
        {
          System.Diagnostics.Debug.WriteLine("**Internal error: bike not found?!");
          return false;
        }

        int rented = Convert.ToInt32(result);

        if (rented == 0)  // not rented:
        {
          return false;
        }

        //
        // Since the bike is rented, display expected return date and time...
        // We have the Bike ID, so we have to join the rental details with the
        // Rentals table to get the rental info --- in particular start time and
        // expected duration.  Note that this bike has probably been rented 
        // before, so to find the correct rental, we want the MOST RECENT rental
        // for this bike.  So we order the rentals by details ID in descending 
        // order, and take the first record (top 1).
        //
        sql = string.Format(@"
SELECT Top 1 StartTime, ExpDuration
FROM Rentals
INNER JOIN RentalDetails ON Rentals.RID = RentalDetails.RID
WHERE BID = {0}
ORDER BY RDID DESC;
", BID);

        DataSet ds = datatier.ExecuteNonScalarQuery(sql);

        if (ds.Tables["TABLE"].Rows.Count == 0)  // not found?!
        {
          System.Diagnostics.Debug.WriteLine("**Internal error, rental record not found?!");
          return false;
        }

        DataRow row = ds.Tables["TABLE"].Rows[0];

        DateTime start = Convert.ToDateTime(row["StartTime"]);
        double duration = Convert.ToDouble(row["ExpDuration"]);

        dueback = start.AddHours(duration);

        return true;  // on rental:
      }
      catch (Exception ex)
      {
        System.Diagnostics.Debug.WriteLine(ex.Message);
        return false;
      }
    }

  }//class

}//namespace
