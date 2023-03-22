using BISBB_SS2023_CB_GA1;
namespace BISBB_SS2023_CB_GA1_tests;

public class UnitTest1
{
    [Fact]
    public void isTrack_test_success()
    {
        List<(int x, int y)> test_track = new List<(int x, int y)>();
        test_track.Add((5, 8));
        test_track.Add((5, 9));
        test_track.Add((5, 10));
        test_track.Add((4, 10));
        test_track.Add((3, 10));
        test_track.Add((3, 11));
        test_track.Add((3, 12));

        Assert.Equal(true, World.isTrack(test_track, 4, 10));
    }

    [Fact]
    public void isTrack_test_noresult()
    {
        List<(int x, int y)> test_track = new List<(int x, int y)>();
        test_track.Add((5, 8));
        test_track.Add((5, 9));
        test_track.Add((5, 10));
        test_track.Add((4, 10));
        test_track.Add((3, 10));
        test_track.Add((3, 11));
        test_track.Add((3, 12));

        Assert.Equal(false, World.isTrack(test_track, 68, 111));
    }

    [Fact]
    public void isTrack_test_exception()
    {
         Assert.Throws<System.NullReferenceException>(() => World.isTrack(null, 68, 111));
    }

    [Fact]
    public void getLastIndexOfSequenceIn2DArray_test_exception() {
        Assert.Throws<System.NullReferenceException>(() => World.getLastIndexOfSequenceIn2DArray(null, null));
        Assert.Throws<System.ArgumentNullException>(() => World.getLastIndexOfSequenceIn2DArray(null, new char[20, 30]));
        Assert.Throws<System.NullReferenceException>(() => World.getLastIndexOfSequenceIn2DArray("score: a", null));
        Assert.Throws<System.NullReferenceException>(() => World.getLastIndexOfSequenceIn2DArray("", null));
    }

    [Fact]
    public void getLastIndexOfSequenceIn2DArray_test_noresult() {
        Assert.Equal((0, 0), World.getLastIndexOfSequenceIn2DArray("", new char[20, 30]));
    }

    [Fact]
    public void getLastIndexOfSequenceIn2DArray_test_success() {

        char[,] test_matrix = {{' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' '},
                               {' ', ' ', ' ','s', 'c', 'o', 'r', 'e', ':',' ', ' ', 'a', ' '},
                               {' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' '}};

        Assert.Equal((11, 1), World.getLastIndexOfSequenceIn2DArray("score:  a", test_matrix));
    }
}