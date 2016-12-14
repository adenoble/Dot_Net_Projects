using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImpactWorks.FBGraph.Connector;
using ImpactWorks.FBGraph.Core;

namespace mmsv4.PostToFacebookWall
{
           public class Authentication
        {
            public Facebook FacebookAuth()
            {
                //Setting up the facebook object
                Facebook facebook = new Facebook();
                facebook.AppID = "353832594985788";
                facebook.Secret = "308444d08eca45509d1e662d485b84ef";
                facebook.CallBackURL = "http://localhost:53582/PostStatus/Success/";

                //Setting up the permissions
                List<FBPermissions> permissions = new List<FBPermissions>() {
                FBPermissions.user_about_me, // to read about me               
                FBPermissions.user_events,
                FBPermissions.user_status,
                FBPermissions.read_stream,
                FBPermissions.friends_events,
                FBPermissions.publish_stream
            };

                //Pass the permissions object to facebook instance
                facebook.Permissions = permissions;
                return facebook;
            }
        }
    }