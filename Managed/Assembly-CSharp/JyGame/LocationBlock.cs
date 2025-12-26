namespace JyGame;

public class LocationBlock
{
	public int X;

	public int Y;

	public LocationBlock()
	{
	}

	public LocationBlock(int P_0, int P_1)
	{
		X = P_0;
		Y = P_1;
	}

	public override bool Equals(object obj)
	{
		return X == (obj as LocationBlock).X && Y == (obj as LocationBlock).Y;
	}

	public override int GetHashCode()
	{
		return X * 10000 + Y;
	}
}
