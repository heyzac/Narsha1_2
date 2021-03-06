﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Forest_For_Rest_H : MonoBehaviour {
    // n(a, b, c);
    // - a -
	// Stab : 1
    // Slash : 2
    // Parring : 3

    // - b -
    // 한 마디 each beat
    
    // - c -
    // 한 마디 안의 16박자 중 순서
    // (1) / 16


	private void OnEnable() {

        GetComponent<ChaeBoSystem>().bpm = 131f;
        ChaeBoSystem.allNote = 0;


                
        n(2, 2, 1);
        n(2, 2, 9);

        n(2, 3, 1);
        n(2, 3, 5);
        n(1, 3, 9);
        n(1, 3, 13);

        n(2, 4, 1);
        n(2, 4, 9);

        n(2, 5, 1);
        n(2, 5, 5);
        n(2, 5, 9);
        n(3, 5, 13);

        n(2, 6, 1);
        n(2, 6, 9);

        n(2, 7, 1);
        n(2, 7, 5);
        n(2, 7, 9);

        n(2, 8, 1);
        n(2, 8, 9);

        n(2, 9, 1);
        n(3, 9, 5);
        n(3, 9, 9);

        n(2, 10, 1);
        n(2, 10, 9);

        n(2, 11, 1);
        n(2, 11, 9);
        n(3, 11, 13);

        n(2, 12, 1);
        n(2, 12, 9);

        n(2, 13, 1);
        n(2, 13, 9);
        n(3, 13, 13);

        n(2, 14, 1);
        n(2, 14, 9);
        n(3, 14, 13);

        n(2, 15, 1);
        n(2, 15, 9);
        n(3, 15, 13);

        n(2, 16, 1);
        n(2, 16, 9);
        n(3, 16, 13);

        n(2, 17, 1);
        n(2, 17, 9);
        n(3, 17, 13);

        n(2, 18, 1);
        n(2, 18, 5);
        n(2, 18, 9);
        n(2, 18, 13);

        n(2, 19, 1);
        n(2, 19, 5);
        n(2, 19, 9);
        n(3, 19, 13);

        n(2, 20, 1);
        n(2, 20, 5);
        n(2, 20, 9);
        n(2, 20, 13);

        n(2, 21, 1);
        n(2, 21, 5);
        n(2, 21, 9);
        n(3, 21, 13);

        n(2, 22, 1);
        n(2, 22, 5);
        n(2, 22, 9);
        n(3, 22, 13);

        n(2, 23, 1);
        n(2, 23, 5);
        n(2, 23, 9);
        n(2, 23, 13);

        n(2, 24, 1);
        n(2, 24, 9);

        n(2, 25, 1);
        n(2, 25, 5);
        n(2, 25, 9);
        n(2, 25, 13);

        n(2, 26, 1);

        n(2, 27, 1);
        n(2, 27, 9);

        n(1, 28, 1);
        n(3, 28, 9);

        n(2, 29, 1);
        n(2, 29, 9);

        n(3, 30, 1);
        n(1, 30, 9);

        n(2, 31, 1);
        n(2, 31, 9);

        n(1, 32, 1);
        n(1, 32, 5);
        n(3, 32, 9);

        n(2, 33, 1);
        n(2, 33, 9);
        n(2, 33, 13);

        n(3, 34, 1);

        n(2, 35, 1);
        n(2, 35, 5);
        n(2, 35, 9);
        n(2, 35, 13);

        n(3, 36, 1);
        n(3, 36, 5);
        n(1, 36, 9);
        n(1, 36, 13);

        n(2, 37, 1);
        n(2, 37, 5);
        n(1, 37, 9);
        n(1, 37, 13);

        n(3, 38, 1);
        n(3, 38, 5);
        n(3, 38, 9);
        n(2, 38, 13);

        n(2, 39, 1);
        n(3, 39, 5);
        n(2, 39, 9);
        n(3, 39, 13);

        n(2, 40, 1);
        n(2, 40, 5);
        n(3, 40, 9);

        n(1, 41, 1);
        n(2, 41, 5);
        n(2, 41, 9);
        n(1, 41, 13);

        n(1, 42, 1);
        n(1, 42, 13);

        n(2, 43, 1);
        n(2, 43, 5);
        n(2, 43, 9);
        n(2, 43, 13);

        n(2, 44, 1);
        n(2, 44, 5);
        n(3, 44, 8);
        n(2, 44, 9);
        n(2, 44, 13);

        n(2, 45, 1);
        n(2, 45, 5);
        n(3, 45, 8);
        n(2, 45, 9);
        n(2, 45, 13);

        n(2, 46, 1);
        n(2, 46, 5);
        n(2, 46, 9);
        n(3, 46, 13);

        n(2, 47, 1);
        n(2, 47, 5);
        n(2, 47, 9);
        n(2, 47, 13);

        n(2, 48, 1);
        n(2, 48, 5);
        n(3, 48, 8);
        n(1, 48, 9);
        n(1, 48, 13);

        n(3, 49, 1);
        n(3, 49, 9);
        n(1, 49, 13);

        n(1, 50, 1);

        enabled = false;
        
    }


    public void n(int shape, int beat, int step) {

        GetComponent<ChaeBoSystem>().m(shape, beat, step);

    }

}