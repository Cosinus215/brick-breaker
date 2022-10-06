using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public Matrix4x4 matrix;
    public ArrayList arr = new ArrayList();

    void Start() {
        //for (int i = 0; i < 4; i++) {
        //    matrix.SetRow(i, Random.Range(4, 10);
        //    //matrix.SetColumn(i, transform.position);
        //}
        //matrix.m22 = transform.position.x;
        //Debug.Log(matrix);
        // get matrix from the Transform
        //var matrix = transform.localToWorldMatrix;
        //arr.Add(1);
        ////ArrayList arr[1,2] = new ArrayList();
        //// get position from the last column
        //for (int i = 0; i < 5; i++) {
        //    Vector3 vektor = new Vector3 (this.transform.position.x + i, this.transform.position.y + i, this.transform.position.z);
        //    matrix.SetColumn(i, vektor);
        //    Debug.Log(matrix.GetColumn(i));
        //    matrix.GetColumn(i) = arr[i];
        //
        //}
        
    }

    
    //Figure out how to add new array
    //how to let matrix choose from the array
    //THINK



    //private void Update() {
    //    for (int i = 0; i < 4; i++) {
    //
    //    }
    //    //var position = new Vector3(matrix[0,3], matrix[1,3], matrix[2,3]);
    //    //this.gameObject.GetComponent<Transform>().position = position;
    //    //Debug.Log("Transform position from matrix is: " + position);
    //}


//    matrix = []
//10.times do
//matrix_row = []
//20.times do
//  #place = [true, false, false].sample
//  place = true
//  matrix_row << place
//end
//matrix << matrix_row
//end
//matrix.each_with_index do |matrix_row, matrix_row_index|
//matrix_row.each_with_index do |matrix_col, matrix_col_index|
//  # create game object
//  # game object.x = (offset_x) + ( width  / matrix_col.count * (matrix_col_index + 1) ) * 10
//  # game object.y = (offset_y) + ( height / matrix_row.count * (matrix_row_index + 1) ) * 10
//end
//end
}
