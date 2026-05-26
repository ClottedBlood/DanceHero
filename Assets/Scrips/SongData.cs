using UnityEngine;

[CreateAssetMenu(fileName = "SongData", menuName = "Scriptable objects/SongData")]
public class SongData : ScriptableObject
{
    public string animationName;

    public string songName;

    public TextAsset noteChart;

    public float speed;
}
