﻿using M3D.Model.Utils;
using M3D.Spooling.Common.Utils;
using System.IO;

namespace M3D.Model.FilIO
{
  public class ModelSTLExporter : ModelExporter
  {
    public void Save(ModelData modelData, string filename)
    {
      byte[] buffer = new byte[80];
      short num = 0;
      using (var fileStream = new FileStream(filename, FileMode.Create))
      {
        using (var binaryWriter = new BinaryWriter((Stream) fileStream))
        {
          binaryWriter.Write(buffer, 0, 80);
          var faceCount = modelData.GetFaceCount();
          binaryWriter.Write(faceCount);
          for (var index = 0; index < faceCount; ++index)
          {
            Vector3 _a = modelData[modelData.GetFace(index).Index1];
            Vector3 _b = modelData[modelData.GetFace(index).Index2];
            Vector3 _c = modelData[modelData.GetFace(index).Index3];
            Vector3 vector3 = ModelData.CalcNormal(_a, _b, _c);
            binaryWriter.Write(vector3.x);
            binaryWriter.Write(vector3.y);
            binaryWriter.Write(vector3.z);
            binaryWriter.Write(_a.x);
            binaryWriter.Write(_a.y);
            binaryWriter.Write(_a.z);
            binaryWriter.Write(_b.x);
            binaryWriter.Write(_b.y);
            binaryWriter.Write(_b.z);
            binaryWriter.Write(_c.x);
            binaryWriter.Write(_c.y);
            binaryWriter.Write(_c.z);
            binaryWriter.Write(num);
          }
          binaryWriter.Close();
        }
        fileStream.Close();
      }
      FileUtils.GrantAccess(filename);
    }
  }
}
