using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenScript : MonoBehaviour
{
    public GameObject[] listAlphabet; // Use "GameObject" with a capital "G"
    int i = 0;

    private void Start()
    {
        for (i = 0; i <= listAlphabet.Length; i++) // Use "Length" instead of "Lengh"
        {
            if (i == 0)
            {
                listAlphabet[0].SetActive(true);
            }
            else
            {
                listAlphabet[i].SetActive(false); // Add a dot before "SetActive"
            }
        }
    }
 // ALPHABET BACK AND FORWARD
 public void gotoA() 
 {
    for (i = 0; i <=listAlphabet.Length ; i++) {
        if (i==0){
            listAlphabet[0].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }

public void gotoB() 
 {
    for (i = 0; i <=listAlphabet.Length; i++) {
        if (i==1){
            listAlphabet[1].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }

public void gotoC() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==2){
            listAlphabet[2].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoD() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==3){
            listAlphabet[3].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoE() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==4){
            listAlphabet[4].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoF() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==5){
            listAlphabet[5].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoG() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==6){
            listAlphabet[6].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoH() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==7){
            listAlphabet[7].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoI() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==8){
            listAlphabet[8].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoJ() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==9){
            listAlphabet[9].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoK() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==10){
            listAlphabet[10].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoL() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==11){
            listAlphabet[11].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoM() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==12){
            listAlphabet[12].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoN() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==13){
            listAlphabet[13].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoO() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==14){
            listAlphabet[14].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
public void gotoP() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==15){
            listAlphabet[15].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoQ() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==16){
            listAlphabet[16].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoR() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==17){
            listAlphabet[17].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoS() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==18){
            listAlphabet[18].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoT() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==19){
            listAlphabet[19].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoU() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==20){
            listAlphabet[20].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoV() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==21){
            listAlphabet[21].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoW() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==22){
            listAlphabet[22].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoX() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==23){
            listAlphabet[23].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoY() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==24){
            listAlphabet[24].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
 public void gotoZ() 
 {
    for (i = 0; i <= listAlphabet.Length; i++) {
        if (i==25){
            listAlphabet[25].SetActive(true);
        }
        else
        {
            listAlphabet[i].SetActive(false);
        }
    }
 }
}
