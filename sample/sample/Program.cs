﻿using System;

    class MyAttribute : Attribute

            for (int i = 0; i < methods.GetLength(0); i++)
            {

                object[] attributesArray = methods[i].GetCustomAttributes(true);

                foreach (Attribute item in attributesArray)
                {
