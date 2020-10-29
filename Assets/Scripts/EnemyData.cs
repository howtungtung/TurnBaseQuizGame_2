[System.Serializable]
public class EnemyData
{
    public int id;
    public string name;
    public int hp;
    public int atk;
    public int battleTurn;

    public EnemyData Clone()
    {
        return (EnemyData)this.MemberwiseClone();
    }
}
