using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace qtools.qmaze
{
    public class Node
    {
        public bool touched;
        public int x;
        public int y;
        public bool visited;
        public List<Node> rawNeighbors;

        public Node up;
        public Node diagonalLeftUp;
        public Node left;
        public Node diagonalLeftDown;
        public Node down;
        public Node diagonalRightDown;
        public Node right;
        public Node diagonalRightUp;
        

       



        public Node(int x, int y)
        {
            this.touched = false;
            this.visited = false;
            this.x = x;
            this.y = y;

        }
        public List<Node> getNeighbours() {

            
            this.up = new Node(this.x, this.y - 1);
            
            this.left = new Node(this.x - 1, this.y);
            
            this.down = new Node(this.x, this.y + 1);
            
            this.right = new Node(this.x + 1, this.y);
            

            //this.diagonalLeftUp = new Node(this.x - 1, this.y - 1);
            //this.diagonalLeftDown = new Node(this.x - 1, this.y + 1);
            //this.diagonalRightDown = new Node(this.x + 1, this.y + 1);
            //this.diagonalRightUp = new Node(this.x + 1, this.y - 1);


            rawNeighbors = new List<Node> { this.up,
                                            //this.diagonalLeftUp,
                                            this.left,
                                            //this.diagonalLeftDown,
                                            this.down,
                                            //this.diagonalRightDown,
                                            this.right,
                                            //this.diagonalRightUp
                                          };
            return rawNeighbors;




        }
    }
}
