/****************************************************************************
Copyright (c) 2010-2011 cocos2d-x.org
Copyright (c) 2008-2011 Ricardo Quesada
Copyright (c) 2011      Zynga Inc.
Copyright (c) 2011      Fulcrum Mobile Network, Inc.

http://www.cocos2d-x.org
http://www.openxlive.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cocos2d.menu_nodes
{
    public class CCMenuItemAtlasFont : CCMenuItemLabel
    {
        public CCMenuItemAtlasFont()
        { }

        /// <summary>
        /// creates a menu item from a string and atlas with a target/selector
        /// </summary>
        public static CCMenuItemAtlasFont itemFromString(string value, string charMapFile, int itemWidth, int itemHeight, char startCharMap)
        {
            return CCMenuItemAtlasFont.itemFromString(value, charMapFile, itemWidth, itemHeight, startCharMap, null, null);
        }

        /// <summary>
        ///  creates a menu item from a string and atlas. Use it with MenuItemToggle
        /// </summary>
        public static CCMenuItemAtlasFont itemFromString(string value, string charMapFile, int itemWidth, int itemHeight, char startCharMap, SelectorProtocol target, SEL_MenuHandler selector)
        {

            CCMenuItemAtlasFont pRet = new CCMenuItemAtlasFont();
            pRet.initFromString(value, charMapFile, itemWidth, itemHeight, startCharMap, target, selector);
            //pRet->autorelease();
            return pRet;
        }

        /// <summary>
        /// initializes a menu item from a string and atlas with a target/selector
        /// </summary>
        public bool initFromString(string value, string charMapFile, int itemWidth, int itemHeight, char startCharMap, SelectorProtocol target, SEL_MenuHandler selector)
        {
            // CCAssert( value != NULL && strlen(value) != 0, "value length must be greater than 0");
            CCLabelAtlas label = new CCLabelAtlas();
            label.initWithString(value, charMapFile, (uint)itemWidth, (uint)itemHeight, startCharMap);
            //label->autorelease();
            if (base.initWithLabel(label, target, selector))
            {
                // do something ?
            }
            return true;
        }
    }
}