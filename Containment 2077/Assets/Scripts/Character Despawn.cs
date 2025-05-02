using UnityEngine;
public class CharacterDespawn : MonoBehaviour
{
    public GameObject charImage;
    public GameObject IDimage;
    public void Despawn()
    {
        GameObject.Destroy(charImage);
        GameObject.Destroy(IDimage);

    }
}
