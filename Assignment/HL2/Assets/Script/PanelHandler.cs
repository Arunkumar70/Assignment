using UnityEngine;
using UnityEngine.UI;

public class PanelHandler : MonoBehaviour
{
    #region Object Field
    [SerializeField] 
    private GameObject item;
    [SerializeField]
    private GameObject content;
    [SerializeField]
    private Image image;
    public Animator anim;
    private int i = 1;
    #endregion
    public void AddItem()
    {
        // Instatiate items in panel 1 
        i++;
        var obj =  Instantiate(item, content.transform);
        obj.GetComponentInChildren<Text>().text = "Item " + i;
    }

    public void ChangeColor(string color)
    {
        // Calling animation every time changing the color
        anim.Play("ScaleImage");
        // Change color of image in panel 2
        switch (color)
        {
            case "Red":
                image.color = Color.red;
                break;
            case "White":
                image.color = Color.white;
                break;
            case "Green":
                image.color = Color.green;
                break;
            case "Blue":
                image.color = Color.blue;
                break;
            case "Black":
                image.color = Color.black;
                break;
            case "Yellow":
                image.color = Color.yellow;
                break;
            case "Gray":
                image.color = Color.gray;
                break;
        }
    }

}
