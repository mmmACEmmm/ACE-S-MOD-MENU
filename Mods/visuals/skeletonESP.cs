using System;
using UnityEngine;
using Object = UnityEngine.Object;


namespace Monkey_Magic_Menu.Mods.visuals
{

    internal class skeletonESP
{
    public static void SkeletonESP()
    {
        foreach (VRRig vrrig in Object.FindObjectsOfType<VRRig>())
        {
            foreach (Transform transform in vrrig.GetComponentsInChildren<Transform>())
            {
                bool flag = transform.name == "head";
                bool flag2 = flag;
                bool flag3 = flag2;
                bool flag4 = flag3;
                bool flag5 = flag4;
                bool flag6 = flag5;
                if (flag6)
                {
                    bool flag7 = transform.gameObject.GetComponent<LineRenderer>() == null;
                    bool flag8 = flag7;
                    bool flag9 = flag8;
                    bool flag10 = flag9;
                    bool flag11 = flag10;
                    bool flag12 = flag11;
                    if (flag12)
                    {
                        transform.gameObject.AddComponent<LineRenderer>();
                        transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                        transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                        transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                        transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                        transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                    }
                    transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, new Vector3(transform.gameObject.transform.position.x, transform.gameObject.transform.position.y + 0.1f, transform.gameObject.transform.position.z));
                    transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, new Vector3(transform.gameObject.transform.position.x, transform.gameObject.transform.position.y - 0.37f, transform.gameObject.transform.position.z));
                }
                bool flag13 = transform.name == "shoulder.R";
                bool flag14 = flag13;
                bool flag15 = flag14;
                bool flag16 = flag15;
                bool flag17 = flag16;
                bool flag18 = flag17;
                if (flag18)
                {
                    foreach (object obj in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform2 = (Transform)obj;
                        bool flag19 = transform2.name == "upper_arm.R";
                        bool flag20 = flag19;
                        bool flag21 = flag20;
                        bool flag22 = flag21;
                        bool flag23 = flag22;
                        bool flag24 = flag23;
                        if (flag24)
                        {
                            bool flag25 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag26 = flag25;
                            bool flag27 = flag26;
                            bool flag28 = flag27;
                            bool flag29 = flag28;
                            bool flag30 = flag29;
                            if (flag30)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform2.transform.position);
                        }
                    }
                }
                bool flag31 = transform.name == "upper_arm.R";
                bool flag32 = flag31;
                bool flag33 = flag32;
                bool flag34 = flag33;
                bool flag35 = flag34;
                bool flag36 = flag35;
                if (flag36)
                {
                    foreach (object obj2 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform3 = (Transform)obj2;
                        bool flag37 = transform3.name == "forearm.R";
                        bool flag38 = flag37;
                        bool flag39 = flag38;
                        bool flag40 = flag39;
                        bool flag41 = flag40;
                        bool flag42 = flag41;
                        if (flag42)
                        {
                            bool flag43 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag44 = flag43;
                            bool flag45 = flag44;
                            bool flag46 = flag45;
                            bool flag47 = flag46;
                            bool flag48 = flag47;
                            if (flag48)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform3.transform.position);
                        }
                    }
                }
                bool flag49 = transform.name == "forearm.R";
                bool flag50 = flag49;
                bool flag51 = flag50;
                bool flag52 = flag51;
                bool flag53 = flag52;
                bool flag54 = flag53;
                if (flag54)
                {
                    foreach (object obj3 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform4 = (Transform)obj3;
                        bool flag55 = transform4.name == "hand.R";
                        bool flag56 = flag55;
                        bool flag57 = flag56;
                        bool flag58 = flag57;
                        bool flag59 = flag58;
                        bool flag60 = flag59;
                        if (flag60)
                        {
                            bool flag61 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag62 = flag61;
                            bool flag63 = flag62;
                            bool flag64 = flag63;
                            bool flag65 = flag64;
                            bool flag66 = flag65;
                            if (flag66)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform4.transform.position);
                        }
                    }
                }
                bool flag67 = transform.name == "hand.R";
                bool flag68 = flag67;
                bool flag69 = flag68;
                bool flag70 = flag69;
                bool flag71 = flag70;
                bool flag72 = flag71;
                if (flag72)
                {
                    foreach (object obj4 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform5 = (Transform)obj4;
                        bool flag73 = transform5.name == "palm.01.R";
                        bool flag74 = flag73;
                        bool flag75 = flag74;
                        bool flag76 = flag75;
                        bool flag77 = flag76;
                        bool flag78 = flag77;
                        if (flag78)
                        {
                            foreach (object obj5 in transform5.GetComponentInChildren<Transform>())
                            {
                                Transform transform6 = (Transform)obj5;
                                bool flag79 = transform6.name == "f_index.01.R";
                                bool flag80 = flag79;
                                bool flag81 = flag80;
                                bool flag82 = flag81;
                                bool flag83 = flag82;
                                bool flag84 = flag83;
                                if (flag84)
                                {
                                    bool flag85 = transform.gameObject.GetComponent<LineRenderer>() == null;
                                    bool flag86 = flag85;
                                    bool flag87 = flag86;
                                    bool flag88 = flag87;
                                    bool flag89 = flag88;
                                    bool flag90 = flag89;
                                    if (flag90)
                                    {
                                        transform.gameObject.AddComponent<LineRenderer>();
                                        transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                        transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                        transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                        transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                        transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                                    }
                                    transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                                    transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform6.transform.position);
                                }
                            }
                        }
                    }
                }
                bool flag91 = transform.name == "palm.02.R";
                bool flag92 = flag91;
                bool flag93 = flag92;
                bool flag94 = flag93;
                bool flag95 = flag94;
                bool flag96 = flag95;
                if (flag96)
                {
                    foreach (object obj6 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform7 = (Transform)obj6;
                        bool flag97 = transform7.name == "f_middle.01.R";
                        bool flag98 = flag97;
                        bool flag99 = flag98;
                        bool flag100 = flag99;
                        bool flag101 = flag100;
                        bool flag102 = flag101;
                        if (flag102)
                        {
                            bool flag103 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag104 = flag103;
                            bool flag105 = flag104;
                            bool flag106 = flag105;
                            bool flag107 = flag106;
                            bool flag108 = flag107;
                            if (flag108)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform7.transform.position);
                        }
                    }
                }
                bool flag109 = transform.name == "f_middle.01.R";
                bool flag110 = flag109;
                bool flag111 = flag110;
                bool flag112 = flag111;
                bool flag113 = flag112;
                bool flag114 = flag113;
                if (flag114)
                {
                    foreach (object obj7 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform8 = (Transform)obj7;
                        bool flag115 = transform8.name == "f_middle.02.R";
                        bool flag116 = flag115;
                        bool flag117 = flag116;
                        bool flag118 = flag117;
                        bool flag119 = flag118;
                        bool flag120 = flag119;
                        if (flag120)
                        {
                            bool flag121 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag122 = flag121;
                            bool flag123 = flag122;
                            bool flag124 = flag123;
                            bool flag125 = flag124;
                            bool flag126 = flag125;
                            if (flag126)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform8.transform.position);
                        }
                    }
                }
                bool flag127 = transform.name == "f_middle.02.R";
                bool flag128 = flag127;
                bool flag129 = flag128;
                bool flag130 = flag129;
                bool flag131 = flag130;
                bool flag132 = flag131;
                if (flag132)
                {
                    foreach (object obj8 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform9 = (Transform)obj8;
                        bool flag133 = transform9.name == "f_middle.03.R";
                        bool flag134 = flag133;
                        bool flag135 = flag134;
                        bool flag136 = flag135;
                        bool flag137 = flag136;
                        bool flag138 = flag137;
                        if (flag138)
                        {
                            bool flag139 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag140 = flag139;
                            bool flag141 = flag140;
                            bool flag142 = flag141;
                            bool flag143 = flag142;
                            bool flag144 = flag143;
                            if (flag144)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform9.transform.position);
                        }
                    }
                }
                bool flag145 = transform.name == "f_middle.03.R";
                bool flag146 = flag145;
                bool flag147 = flag146;
                bool flag148 = flag147;
                bool flag149 = flag148;
                bool flag150 = flag149;
                if (flag150)
                {
                    foreach (object obj9 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform10 = (Transform)obj9;
                        bool flag151 = transform10.name == "f_middle.03.R_end";
                        bool flag152 = flag151;
                        bool flag153 = flag152;
                        bool flag154 = flag153;
                        bool flag155 = flag154;
                        bool flag156 = flag155;
                        if (flag156)
                        {
                            bool flag157 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag158 = flag157;
                            bool flag159 = flag158;
                            bool flag160 = flag159;
                            bool flag161 = flag160;
                            bool flag162 = flag161;
                            if (flag162)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform10.transform.position);
                        }
                    }
                }
                bool flag163 = transform.name == "palm.01.R";
                bool flag164 = flag163;
                bool flag165 = flag164;
                bool flag166 = flag165;
                bool flag167 = flag166;
                bool flag168 = flag167;
                if (flag168)
                {
                    foreach (object obj10 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform11 = (Transform)obj10;
                        bool flag169 = transform11.name == "f_index.01.R";
                        bool flag170 = flag169;
                        bool flag171 = flag170;
                        bool flag172 = flag171;
                        bool flag173 = flag172;
                        bool flag174 = flag173;
                        if (flag174)
                        {
                            bool flag175 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag176 = flag175;
                            bool flag177 = flag176;
                            bool flag178 = flag177;
                            bool flag179 = flag178;
                            bool flag180 = flag179;
                            if (flag180)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform11.transform.position);
                        }
                    }
                }
                bool flag181 = transform.name == "f_index.01.R";
                bool flag182 = flag181;
                bool flag183 = flag182;
                bool flag184 = flag183;
                bool flag185 = flag184;
                bool flag186 = flag185;
                if (flag186)
                {
                    foreach (object obj11 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform12 = (Transform)obj11;
                        bool flag187 = transform12.name == "f_index.02.R";
                        bool flag188 = flag187;
                        bool flag189 = flag188;
                        bool flag190 = flag189;
                        bool flag191 = flag190;
                        bool flag192 = flag191;
                        if (flag192)
                        {
                            bool flag193 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag194 = flag193;
                            bool flag195 = flag194;
                            bool flag196 = flag195;
                            bool flag197 = flag196;
                            bool flag198 = flag197;
                            if (flag198)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform12.transform.position);
                        }
                    }
                }
                bool flag199 = transform.name == "f_index.02.R";
                bool flag200 = flag199;
                bool flag201 = flag200;
                bool flag202 = flag201;
                bool flag203 = flag202;
                bool flag204 = flag203;
                if (flag204)
                {
                    foreach (object obj12 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform13 = (Transform)obj12;
                        bool flag205 = transform13.name == "f_index.03.R";
                        bool flag206 = flag205;
                        bool flag207 = flag206;
                        bool flag208 = flag207;
                        bool flag209 = flag208;
                        bool flag210 = flag209;
                        if (flag210)
                        {
                            bool flag211 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag212 = flag211;
                            bool flag213 = flag212;
                            bool flag214 = flag213;
                            bool flag215 = flag214;
                            bool flag216 = flag215;
                            if (flag216)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform13.transform.position);
                        }
                    }
                }
                bool flag217 = transform.name == "f_index.03.R";
                bool flag218 = flag217;
                bool flag219 = flag218;
                bool flag220 = flag219;
                bool flag221 = flag220;
                bool flag222 = flag221;
                if (flag222)
                {
                    foreach (object obj13 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform14 = (Transform)obj13;
                        bool flag223 = transform14.name == "f_index.03.R_end";
                        bool flag224 = flag223;
                        bool flag225 = flag224;
                        bool flag226 = flag225;
                        bool flag227 = flag226;
                        bool flag228 = flag227;
                        if (flag228)
                        {
                            bool flag229 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag230 = flag229;
                            bool flag231 = flag230;
                            bool flag232 = flag231;
                            bool flag233 = flag232;
                            bool flag234 = flag233;
                            if (flag234)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.red;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.green;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform14.transform.position);
                        }
                    }
                }
                bool flag235 = transform.name == "shoulder.L";
                bool flag236 = flag235;
                bool flag237 = flag236;
                bool flag238 = flag237;
                bool flag239 = flag238;
                bool flag240 = flag239;
                if (flag240)
                {
                    foreach (object obj14 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform15 = (Transform)obj14;
                        bool flag241 = transform15.name == "upper_arm.L";
                        bool flag242 = flag241;
                        bool flag243 = flag242;
                        bool flag244 = flag243;
                        bool flag245 = flag244;
                        bool flag246 = flag245;
                        if (flag246)
                        {
                            bool flag247 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag248 = flag247;
                            bool flag249 = flag248;
                            bool flag250 = flag249;
                            bool flag251 = flag250;
                            bool flag252 = flag251;
                            if (flag252)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform15.transform.position);
                        }
                    }
                }
                bool flag253 = transform.name == "upper_arm.L";
                bool flag254 = flag253;
                bool flag255 = flag254;
                bool flag256 = flag255;
                bool flag257 = flag256;
                bool flag258 = flag257;
                if (flag258)
                {
                    foreach (object obj15 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform16 = (Transform)obj15;
                        bool flag259 = transform16.name == "forearm.L";
                        bool flag260 = flag259;
                        bool flag261 = flag260;
                        bool flag262 = flag261;
                        bool flag263 = flag262;
                        bool flag264 = flag263;
                        if (flag264)
                        {
                            bool flag265 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag266 = flag265;
                            bool flag267 = flag266;
                            bool flag268 = flag267;
                            bool flag269 = flag268;
                            bool flag270 = flag269;
                            if (flag270)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform16.transform.position);
                        }
                    }
                }
                bool flag271 = transform.name == "forearm.L";
                bool flag272 = flag271;
                bool flag273 = flag272;
                bool flag274 = flag273;
                bool flag275 = flag274;
                bool flag276 = flag275;
                if (flag276)
                {
                    foreach (object obj16 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform17 = (Transform)obj16;
                        bool flag277 = transform17.name == "hand.L";
                        bool flag278 = flag277;
                        bool flag279 = flag278;
                        bool flag280 = flag279;
                        bool flag281 = flag280;
                        bool flag282 = flag281;
                        if (flag282)
                        {
                            bool flag283 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag284 = flag283;
                            bool flag285 = flag284;
                            bool flag286 = flag285;
                            bool flag287 = flag286;
                            bool flag288 = flag287;
                            if (flag288)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform17.transform.position);
                        }
                    }
                }
                bool flag289 = transform.name == "hand.L";
                bool flag290 = flag289;
                bool flag291 = flag290;
                bool flag292 = flag291;
                bool flag293 = flag292;
                bool flag294 = flag293;
                if (flag294)
                {
                    foreach (object obj17 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform18 = (Transform)obj17;
                        bool flag295 = transform18.name == "palm.01.L";
                        bool flag296 = flag295;
                        bool flag297 = flag296;
                        bool flag298 = flag297;
                        bool flag299 = flag298;
                        bool flag300 = flag299;
                        if (flag300)
                        {
                            foreach (object obj18 in transform18.GetComponentInChildren<Transform>())
                            {
                                Transform transform19 = (Transform)obj18;
                                bool flag301 = transform19.name == "f_index.01.L";
                                bool flag302 = flag301;
                                bool flag303 = flag302;
                                bool flag304 = flag303;
                                bool flag305 = flag304;
                                bool flag306 = flag305;
                                if (flag306)
                                {
                                    bool flag307 = transform.gameObject.GetComponent<LineRenderer>() == null;
                                    bool flag308 = flag307;
                                    bool flag309 = flag308;
                                    bool flag310 = flag309;
                                    bool flag311 = flag310;
                                    bool flag312 = flag311;
                                    if (flag312)
                                    {
                                        transform.gameObject.AddComponent<LineRenderer>();
                                        transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                        transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                        transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                        transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                        transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                                    }
                                    transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                                    transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform19.transform.position);
                                }
                            }
                        }
                    }
                }
                bool flag313 = transform.name == "palm.02.L";
                bool flag314 = flag313;
                bool flag315 = flag314;
                bool flag316 = flag315;
                bool flag317 = flag316;
                bool flag318 = flag317;
                if (flag318)
                {
                    foreach (object obj19 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform20 = (Transform)obj19;
                        bool flag319 = transform20.name == "f_middle.01.L";
                        bool flag320 = flag319;
                        bool flag321 = flag320;
                        bool flag322 = flag321;
                        bool flag323 = flag322;
                        bool flag324 = flag323;
                        if (flag324)
                        {
                            bool flag325 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag326 = flag325;
                            bool flag327 = flag326;
                            bool flag328 = flag327;
                            bool flag329 = flag328;
                            bool flag330 = flag329;
                            if (flag330)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform20.transform.position);
                        }
                    }
                }
                bool flag331 = transform.name == "f_middle.01.L";
                bool flag332 = flag331;
                bool flag333 = flag332;
                bool flag334 = flag333;
                bool flag335 = flag334;
                bool flag336 = flag335;
                if (flag336)
                {
                    foreach (object obj20 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform21 = (Transform)obj20;
                        bool flag337 = transform21.name == "f_middle.02.L";
                        bool flag338 = flag337;
                        bool flag339 = flag338;
                        bool flag340 = flag339;
                        bool flag341 = flag340;
                        bool flag342 = flag341;
                        if (flag342)
                        {
                            bool flag343 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag344 = flag343;
                            bool flag345 = flag344;
                            bool flag346 = flag345;
                            bool flag347 = flag346;
                            bool flag348 = flag347;
                            if (flag348)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform21.transform.position);
                        }
                    }
                }
                bool flag349 = transform.name == "f_middle.02.L";
                bool flag350 = flag349;
                bool flag351 = flag350;
                bool flag352 = flag351;
                bool flag353 = flag352;
                bool flag354 = flag353;
                if (flag354)
                {
                    foreach (object obj21 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform22 = (Transform)obj21;
                        bool flag355 = transform22.name == "f_middle.03.L";
                        bool flag356 = flag355;
                        bool flag357 = flag356;
                        bool flag358 = flag357;
                        bool flag359 = flag358;
                        bool flag360 = flag359;
                        if (flag360)
                        {
                            bool flag361 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag362 = flag361;
                            bool flag363 = flag362;
                            bool flag364 = flag363;
                            bool flag365 = flag364;
                            bool flag366 = flag365;
                            if (flag366)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform22.transform.position);
                        }
                    }
                }
                bool flag367 = transform.name == "f_middle.03.L";
                bool flag368 = flag367;
                bool flag369 = flag368;
                bool flag370 = flag369;
                bool flag371 = flag370;
                bool flag372 = flag371;
                if (flag372)
                {
                    foreach (object obj22 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform23 = (Transform)obj22;
                        bool flag373 = transform23.name == "f_middle.03.L_end";
                        bool flag374 = flag373;
                        bool flag375 = flag374;
                        bool flag376 = flag375;
                        bool flag377 = flag376;
                        bool flag378 = flag377;
                        if (flag378)
                        {
                            bool flag379 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag380 = flag379;
                            bool flag381 = flag380;
                            bool flag382 = flag381;
                            bool flag383 = flag382;
                            bool flag384 = flag383;
                            if (flag384)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform23.transform.position);
                        }
                    }
                }
                bool flag385 = transform.name == "palm.01.L";
                bool flag386 = flag385;
                bool flag387 = flag386;
                bool flag388 = flag387;
                bool flag389 = flag388;
                bool flag390 = flag389;
                if (flag390)
                {
                    foreach (object obj23 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform24 = (Transform)obj23;
                        bool flag391 = transform24.name == "f_index.01.L";
                        bool flag392 = flag391;
                        bool flag393 = flag392;
                        bool flag394 = flag393;
                        bool flag395 = flag394;
                        bool flag396 = flag395;
                        if (flag396)
                        {
                            bool flag397 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag398 = flag397;
                            bool flag399 = flag398;
                            bool flag400 = flag399;
                            bool flag401 = flag400;
                            bool flag402 = flag401;
                            if (flag402)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform24.transform.position);
                        }
                    }
                }
                bool flag403 = transform.name == "f_index.01.L";
                bool flag404 = flag403;
                bool flag405 = flag404;
                bool flag406 = flag405;
                bool flag407 = flag406;
                bool flag408 = flag407;
                if (flag408)
                {
                    foreach (object obj24 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform25 = (Transform)obj24;
                        bool flag409 = transform25.name == "f_index.02.L";
                        bool flag410 = flag409;
                        bool flag411 = flag410;
                        bool flag412 = flag411;
                        bool flag413 = flag412;
                        bool flag414 = flag413;
                        if (flag414)
                        {
                            bool flag415 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag416 = flag415;
                            bool flag417 = flag416;
                            bool flag418 = flag417;
                            bool flag419 = flag418;
                            bool flag420 = flag419;
                            if (flag420)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform25.transform.position);
                        }
                    }
                }
                bool flag421 = transform.name == "f_index.02.L";
                bool flag422 = flag421;
                bool flag423 = flag422;
                bool flag424 = flag423;
                bool flag425 = flag424;
                bool flag426 = flag425;
                if (flag426)
                {
                    foreach (object obj25 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform26 = (Transform)obj25;
                        bool flag427 = transform26.name == "f_index.03.L";
                        bool flag428 = flag427;
                        bool flag429 = flag428;
                        bool flag430 = flag429;
                        bool flag431 = flag430;
                        bool flag432 = flag431;
                        if (flag432)
                        {
                            bool flag433 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag434 = flag433;
                            bool flag435 = flag434;
                            bool flag436 = flag435;
                            bool flag437 = flag436;
                            bool flag438 = flag437;
                            if (flag438)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform26.transform.position);
                        }
                    }
                }
                bool flag439 = transform.name == "f_index.03.L";
                bool flag440 = flag439;
                bool flag441 = flag440;
                bool flag442 = flag441;
                bool flag443 = flag442;
                bool flag444 = flag443;
                if (flag444)
                {
                    foreach (object obj26 in transform.GetComponentInChildren<Transform>())
                    {
                        Transform transform27 = (Transform)obj26;
                        bool flag445 = transform27.name == "f_index.03.L_end";
                        bool flag446 = flag445;
                        bool flag447 = flag446;
                        bool flag448 = flag447;
                        bool flag449 = flag448;
                        bool flag450 = flag449;
                        if (flag450)
                        {
                            bool flag451 = transform.gameObject.GetComponent<LineRenderer>() == null;
                            bool flag452 = flag451;
                            bool flag453 = flag452;
                            bool flag454 = flag453;
                            bool flag455 = flag454;
                            bool flag456 = flag455;
                            if (flag456)
                            {
                                transform.gameObject.AddComponent<LineRenderer>();
                                transform.gameObject.GetComponent<LineRenderer>().startWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().endWidth = 0.01f;
                                transform.gameObject.GetComponent<LineRenderer>().startColor = Color.black;
                                transform.gameObject.GetComponent<LineRenderer>().endColor = Color.magenta;
                                transform.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GUI/Text Shader");
                            }
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.gameObject.transform.position);
                            transform.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform27.transform.position);
                        }
                    }
                }
            }
        }
    }

}
}
