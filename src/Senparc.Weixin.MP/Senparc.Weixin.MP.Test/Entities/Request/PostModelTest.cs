﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2017 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Senparc.Weixin.MP.Entities.Request;

namespace Senparc.Weixin.MP.Test.Entities.Request
{
    [TestClass]
   public class PostModelTest
    {
        [TestMethod]
        public void SetSecretInfoTest()
        {
            var postModel = new PostModel();
            postModel.SetSecretInfo("A","B","C");
            Assert.AreEqual("A", postModel.Token);
            Assert.AreEqual("B", postModel.EncodingAESKey);
            Assert.AreEqual("C", postModel.AppId);
        }
    }
}
