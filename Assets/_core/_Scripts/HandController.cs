using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public List<Card> heldCards = new List<Card>();

    public Transform minPosition, maxPosition;
    public List<Vector3> cardPositions = new List<Vector3>();

    public float arcWidth = 5f; // Width of the arc
    public float arcDepth = 1f; // Depth of the arc on the Z-axis
    public float maxRotationAngle = 15f; // Maximum rotation angle for the cards

    void Start()
    {
        SetCardPositionsInHand();
    }

    void Update()
    {

    }

    public void SetCardPositionsInHand()
    {
        cardPositions.Clear();
        Vector3 distanceBetweenPoints = Vector3.zero;

        if (heldCards.Count > 1) // Calculate distance between points.
            distanceBetweenPoints = (maxPosition.position - minPosition.position) / (heldCards.Count - 1);

        for (int i = 0; i < heldCards.Count; i++)
        {
            AddCardPosition(i, distanceBetweenPoints);
            SetCardToHandPosition(i);
        }
    }

    private void AddCardPosition(int i, Vector3 distanceBetweenPoints)
    {
        Vector3 basePosition = minPosition.position + (distanceBetweenPoints * i);
        float t = (float)i / (heldCards.Count - 1);
        float arcX = Mathf.Lerp(minPosition.position.x, maxPosition.position.x, t);
        float arcZ = Mathf.Sin(t * Mathf.PI) * arcDepth; // Create the arc effect in Z direction
        cardPositions.Add(new Vector3(arcX, basePosition.y, basePosition.z + arcZ));
    }

    private void SetCardToHandPosition(int cardIndex)
    {
        heldCards[cardIndex].transform.position = cardPositions[cardIndex];

        float t = (float)cardIndex / (heldCards.Count - 1);
        float rotationAngle = Mathf.Lerp(-maxRotationAngle, maxRotationAngle, t);
        heldCards[cardIndex].transform.rotation = Quaternion.Euler(0, rotationAngle, -5);
    }
}