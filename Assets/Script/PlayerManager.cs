using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    public static Vector2 lastCheckPointPos = new Vector2(-8.6f,-6.2f);

    public CinemachineVirtualCamera VCam;
    public GameObject[] playerPrefabs;
    int characterIndex;

    private void Awake()
    {
        characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        GameObject player = Instantiate(playerPrefabs[characterIndex], lastCheckPointPos, Quaternion.identity);
        VCam.m_Follow = player.transform;
    }
}
