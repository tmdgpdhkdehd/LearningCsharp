using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 첫번째 TreeView 아이템 - 서버
            TreeNode svrNode = new TreeNode("과목", 0, 0);
            svrNode.Nodes.Add("C", "C", 0, 0);
            svrNode.Nodes.Add("CPP", "CPP", 0, 0);
            svrNode.Nodes.Add("CSharp", "CSharp", 0, 0);

            // 두번째 TreeView 아이템 - 네트웍
            TreeNode netNode = new TreeNode("엔진", 1, 1);
            netNode.Nodes.Add("유니티", "유니티", 1, 1);
            netNode.Nodes.Add("언리얼", "언리얼", 1, 1);
            netNode.Nodes.Add("게임브리오", "게임브리오", 1, 1);

            // 2개의 노드를 TreeView에 추가
            treeView1.Nodes.Add(svrNode);
            treeView1.Nodes.Add(netNode);

            // 모든 트리 노드를 보여준다
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeKey = e.Node.Name;
            if (!string.IsNullOrEmpty(nodeKey))
            {
                MessageBox.Show("선택된 노드 키 : " + nodeKey);
            }
        }
    }
}
