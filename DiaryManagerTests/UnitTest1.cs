using DiaryManager;
namespace DiaryManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void Readcontent()
        {
            // Arrange
            string path = @"..\..\..\DiaryTest.txt";
            string date = "2024-06-28";
            string content = "Today I went to the beach. It was a sunny day, and the weather was perfect for a swim.I spent a few hours relaxing by the shore, reading a book, and enjoying the sound of the waves.In the afternoon, I had a delicious picnic lunch with my friends, followed by a game of beach volleyball.Later in the evening, we watched the sunset and had a bonfire. It was an amazing day!";
            string content_toread = $"{date} \n {content}\n";
            // Create an instance of DailyDiary and add content
            DailyDiary dailyDiary = new DailyDiary();
            dailyDiary.Addcontent(date, content, path);

            //Act
            string result=dailyDiary.Readcontent(date,path);

            //assert

            Assert.Equal(content_toread, result);

        }

        //[Fact]
        //public void Addcontent()
        //{
        //    //assign
        //    string path = @"..\..\..\DiaryTest.txt";
        //    string date = "2024-06-8";
        //    string content = "Today I went to the beach. It was a sunny day, and the weather was perfect for a swim. \r\nI spent a few hours relaxing by the shore, reading a book, and enjoying the sound of the waves. \r\nIn the afternoon, I had a delicious picnic lunch with my friends, followed by a game of beach volleyball.\r\nLater in the evening, we watched the sunset and had a bonfire. It was an amazing day!";

        //    //Act
        //    DailyDiary dailyDiary = new DailyDiary();
        //    string result = dailyDiary.Addcontent(date,content, path);

        //    //assert

        //    Assert.Equal(result, "Sorry content for this date already exists :<\n");
        //}

        [Fact]
        public void countlines()
        {

            // Arrange
            string path = @"..\..\..\DiaryTest.txt";
            string date = "2024-06-28";
            string content = "Today I went to the beach. It was a sunny day, and the weather was perfect for a swim.I spent a few hours relaxing by the shore, reading a book, and enjoying the sound of the waves.In the afternoon, I had a delicious picnic lunch with my friends, followed by a game of beach volleyball.Later in the evening, we watched the sunset and had a bonfire. It was an amazing day!";

            // Create an instance of DailyDiary and add content
            DailyDiary dailyDiary = new DailyDiary();
            dailyDiary.Addcontent(date, content, path);

            // Act: Count lines after adding content
            int result = dailyDiary.count_lines(path);

            // Assert: Verify the number of lines matches the expected count
            Assert.Equal(result, 2);

        }

        [Fact]
        public void delete_content() {

            //Assign
            string date = "2024-06-28";
            string content = "Today I went to the beach. It was a sunny day, and the weather was perfect for a swim.I spent a few hours relaxing by the shore, reading a book, and enjoying the sound of the waves.In the afternoon, I had a delicious picnic lunch with my friends, followed by a game of beach volleyball.Later in the evening, we watched the sunset and had a bonfire. It was an amazing day!\r\n";
            string path= @"..\..\..\DiaryTest.txt";

            //Act
            DailyDiary dailyDiary = new DailyDiary();
            string result= dailyDiary.Deletecontent(date,content,path);

            //Assert
            Assert.Equal(result, "Entry deleted successfully :) \n");


        }

        [Fact]
        public void ReadAll() {

            //Assign
            string path = @"..\..\..\DiaryTest.txt";
            string content_toread = $"2024-06-28" +
                $"Today I went to the beach. It was a sunny day, and the weather was perfect for a swim.I spent a few hours relaxing by the shore, reading a book, and enjoying the sound of the waves.In the afternoon, I had a delicious picnic lunch with my friends, followed by a game of beach volleyball.Later in the evening, we watched the sunset and had a bonfire. It was an amazing day!\n";
            //Act
            DailyDiary dailyDiary = new DailyDiary();
            string result=dailyDiary.ReadAll(path);

            //Assert
            Assert.Equal(result, content_toread);

        }
    }
}