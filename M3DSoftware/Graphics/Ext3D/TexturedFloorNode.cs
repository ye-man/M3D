﻿using M3D.Graphics.Ext3D.ModelRendering;
using OpenTK;
using System.Collections.Generic;

namespace M3D.Graphics.Ext3D
{
  public class TexturedFloorNode : CustomShape
  {
    public TexturedFloorNode()
      : this(0, (Element3D) null)
    {
    }

    public TexturedFloorNode(int ID)
      : this(ID, (Element3D) null)
    {
    }

    public TexturedFloorNode(int ID, Element3D parent)
      : base(ID, parent)
    {
    }

    public void Create(M3D.Model.Utils.Vector3 pos, float xWidth, float yWidth, int opengl_texture_handle)
    {
      var num1 = xWidth / 2f;
      var num2 = yWidth / 2f;
      var vector3_1 = new M3D.Model.Utils.Vector3(pos.x + num1, pos.y + num2, pos.z);
      var vector3_2 = new M3D.Model.Utils.Vector3(pos.x - num1, pos.y - num2, pos.z);
      Create(new List<VertexTNV>()
      {
        new VertexTNV(new Vector2(0.0f, 0.0f), new M3D.Model.Utils.Vector3(0.0f, 0.0f, 1f), new M3D.Model.Utils.Vector3(vector3_2.x, vector3_2.y, vector3_1.z)),
        new VertexTNV(new Vector2(1f, 0.0f), new M3D.Model.Utils.Vector3(0.0f, 0.0f, 1f), new M3D.Model.Utils.Vector3(vector3_1.x, vector3_2.y, vector3_1.z)),
        new VertexTNV(new Vector2(1f, 1f), new M3D.Model.Utils.Vector3(0.0f, 0.0f, 1f), new M3D.Model.Utils.Vector3(vector3_1.x, vector3_1.y, vector3_1.z)),
        new VertexTNV(new Vector2(1f, 1f), new M3D.Model.Utils.Vector3(0.0f, 0.0f, 1f), new M3D.Model.Utils.Vector3(vector3_1.x, vector3_1.y, vector3_1.z)),
        new VertexTNV(new Vector2(0.0f, 1f), new M3D.Model.Utils.Vector3(0.0f, 0.0f, 1f), new M3D.Model.Utils.Vector3(vector3_2.x, vector3_1.y, vector3_1.z)),
        new VertexTNV(new Vector2(0.0f, 0.0f), new M3D.Model.Utils.Vector3(0.0f, 0.0f, 1f), new M3D.Model.Utils.Vector3(vector3_2.x, vector3_2.y, vector3_1.z))
      }, opengl_texture_handle);
    }
  }
}
