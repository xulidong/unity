﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private GameObject player;
	private Vector3 offset;

	void Start () {
		player = GameObject.Find("Player");
		offset = transform.position - player.transform.position;
	}

	void Update () {
		transform.position = player.transform.position + offset;
	}
}
