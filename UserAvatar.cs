using UnityEngine;

public class UserAvatar : MonoBehaviour
{
    public string username;
    public GameObject avatarModel;

    public void Initialize(string name, GameObject model)
    {
        username = name;
        avatarModel = Instantiate(model, transform.position, transform.rotation);
        Debug.Log($"Аватар пользователя {username} создан.");
    }
}
