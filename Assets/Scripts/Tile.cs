using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Tile : MonoBehaviour
{
    Color varColor;
    public TextManager textManager;
    public string tileName;
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private MeshRenderer _renderer;

    [SerializeField] private GameObject _highlight;

    bool isObstacle = false;
    public void Init(bool isOffset)
    {
        _renderer.material.color = isOffset ? _offsetColor : _baseColor;
        varColor = _renderer.material.color;
    }
    public void OnMouseEnter()
    {
        _renderer.material.color = new Color(3, 124, 255, 20);
        var text = "Hello I am a tile and I am at " + name;
        textManager.displayText(text);

    }
    public void OnMouseExit()
    {
        _renderer.material.color = varColor;
    }
    public void OnMouseDown()
    {
        isObstacle = !isObstacle;
        _renderer.material.color = new Color(0, 0, 0, 0);
        if(isObstacle){
        var text = name + " is now an obstacle";
        textManager.displayText(text);
        }else{
        var text = name + " is now not an obstacle";
        textManager.displayText(text);
        }
    }
    public void CheckForObstacle()
    {
        if (isObstacle)
        {
            _renderer.material.color = new Color(0, 0, 0, 0);
            var basePosn = transform.position;
            transform.position = new Vector3(basePosn.x, basePosn.y, -0.18f);
        }
        else if (!isObstacle)
        {
            _renderer.material.color = varColor;
        }
    }
    void Update()
    {
        CheckForObstacle();
    }
}
