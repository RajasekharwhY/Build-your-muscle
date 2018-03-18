<Query Kind="Program" />

void Main()
{
// Copyright © 2018 CourtAlert.com Inc.
	const string fileName = @"C:\Olympus Folder\Test\restaurant-ratings.csv";
	String[] lines = File.ReadAllLines(fileName);
	//output the lines
	lines = lines.Skip(1).ToArray();  
	lines.Dump();
	//todo calculate the average rating for each city and display the name of the city with the highest average
	List<cityCuisineRating> listRatings = createCityCuisineRatings(lines);	
	var cityAverageScores = from listRating in listRatings
    						group listRating by listRating.CityName into cityGroup
   							select new
   							{
       						 City = cityGroup.Key,
       						 AverageScore = cityGroup.Average(x => x.Score),
   							};
	// Get the city with Max average score. 
	var maxAvgScore = cityAverageScores.OrderByDescending(item => item.AverageScore).First();
	Console.WriteLine( maxAvgScore.City + " is the city with Max Avg Score of " + maxAvgScore.AverageScore);
	
}

// Define other methods and classes here
public class cityCuisineRating
{
    public int ID { get; set; }
	public string CityName { get; set; }
    public string Cuisine { get; set; }
    public int Score { get; set; }
}

List<cityCuisineRating> createCityCuisineRatings (string[] cityCuisineRatingsLists)
{
	 List<cityCuisineRating> cityCuisineRatings = new List<cityCuisineRating>();
	 foreach (string cityCuisineRatingsList in cityCuisineRatingsLists)
	 {
	       string [] cityCuisineRatingsArry = cityCuisineRatingsList.Split(',');
		   cityCuisineRatings.Add (new cityCuisineRating {ID = Convert.ToInt32(cityCuisineRatingsArry[0]), CityName=cityCuisineRatingsArry[1], Cuisine=cityCuisineRatingsArry[2], Score  = Convert.ToInt32(cityCuisineRatingsArry[3])});
	 }
	return cityCuisineRatings;
}