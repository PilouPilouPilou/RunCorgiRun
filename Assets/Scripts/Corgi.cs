using System;
using System.Collections;
using System.Threading;
using UnityEngine;

public class Corgi : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isDrunk = false;
    public Sprite DrunkSprite;
    public Sprite SoberSprite;
    private Coroutine soberUpCoroutine;
    
    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void Move(Vector2 direction)
    {
        direction = ApplyDrunkenness(direction);
        
        FaceCorrectDirection(direction);
        
        Vector2 movementAmount = direction * (GameParameters.CorgiMoveSpeed * Time.deltaTime);
        
        spriteRenderer.transform.Translate(movementAmount.x,movementAmount.y,0);

        spriteRenderer.transform.position = SpriteTools.ConstrainToScreen(spriteRenderer);
    }

    private Vector2 ApplyDrunkenness(Vector2 direction)
    {
        if (isDrunk)
        {
            direction.x = direction.x * -1;
            direction.y = direction.y * -1;
        }
        return direction;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        print(message: "boom");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Beer")
        {
            GetDrunk();
            Destroy(other.gameObject);
        }
        if (other.tag == "Bone")
        {
            print(message: "Do bone things");
        }
        if (other.tag == "Pill")
        {
            print(message: "Do pill things");
        }
    }

    private void GetDrunk()
    {
        isDrunk = true;
        ChangeToDrunkSprite();
        StartSoberingUp();
    }

    private void StartSoberingUp()
    {
        if (soberUpCoroutine != null)
            StopCoroutine(soberUpCoroutine);
        soberUpCoroutine = StartCoroutine(CountdownUntilSober());
    }

    IEnumerator CountdownUntilSober()
    {
        yield return new WaitForSeconds(GameParameters.CorgiDrunkSeconds);
        SoberUp();
    }

    private void SoberUp()
    {
        ChangeToSoberSprite();
        isDrunk = false;
    }

    private void ChangeToSoberSprite()
    {
        spriteRenderer.sprite = SoberSprite;
    }

    private void ChangeToDrunkSprite()
    {
        spriteRenderer.sprite = DrunkSprite;
    }

    private void FaceCorrectDirection(Vector2 direction)
    {
        if (direction.x > 0)
        { 
            spriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    public Vector3 GetPosition()
    {
        return spriteRenderer.transform.position;
    }
}
