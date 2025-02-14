using UnityEngine;

public class Whiteboard : MonoBehaviour
{
    public Texture2D texture;
    public Vector2 textureSize = new Vector2(2048, 2048);

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        var renderer = GetComponent<Renderer>();
        texture = new Texture2D((int)textureSize.x, (int)textureSize.y);
        renderer.material.mainTexture = texture;
    }

    public void Draw(Vector2 position, Color color)
    {
        int x = (int)(position.x * textureSize.x);
        int y = (int)(position.y * textureSize.y);
        texture.SetPixel(x, y, color);
        texture.Apply();
    }

    public void Clear()
    {
        texture = new Texture2D((int)textureSize.x, (int)textureSize.y);
        GetComponent<Renderer>().material.mainTexture = texture;
    }
}
