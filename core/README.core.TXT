ClockSkinMaker core
==================================

Copyright (c) 2016 richi <rromeroa@hotmail.com>

ClockSkinMaker is distributed under the GNU General Public License GPLv3 or
higher, please see LICENSE.TXT for details.

The included software is provided as-is by Ricardo Romero.

IMPORTANT
==================================
YOU AGREE THAT YOUR USE OF THIS SOFTWARE IS ENTIRELY AT YOUR OWN RISK.

KNOWN ISSUES AND LIMITATIONS
==================================
- The "pedometer text" and "heartrate text" elements are not implemented.


CHANGELOG
==================================
2020/03/30  1.4.0.0 - Implemented dynamics SkinCanvas dimensions
2017/02/11  1.3.0.0 - Implementing firmware behavior (rotate battery, array_second alignment, anticlokwise dependent on layers)
                    Thanks to "Andrew Somers" for collaborating in the tests.
                    Thanks to "Alessandro Limonta" provide solutions and fixes to issues. Special thanks for his to contribute in source code.
2016/11/12  1.2.0.0 - Implemented leading character functionality into "array_steps" (creation arrays and preview). 
                    Thanks to "Derk-Jan Woltjer" who has warned of this functionality and collaborated with tests.
                    - Prevent image filenames starting with dot.
2016/06/02  1.1.1.0 - Remove previous/actual value compare in CSkinPanel.Sample
2016/05/28  1.1.0.0 - Rebuild with Framework 4.6
2016/05/04  1.0.2.0 - Changed temperature arrays view size (exclude minus)
2016/04/23  1.0.1.0 - Changed description rotate_daynight to rotate_24hrs
                    - Changed precision of CSkinPanel sample value
2016/03/18  1.0.0.0 - Licensed changed to gpl, published in codeplex

PREVIOUS UPDATES FROM GUI INTEGRATED
==================================
2016/03/16  1.3.1.0 - Remove install fonts from .watch, the fonts cannot be used (microsoft issue)
2016/03/15  1.3.0.0 - Added shadow options on ArrayGenerator
                    - Simulate Rotate hours in "automatic" mode
2016/03/14  1.2.1.0 - Fixed save array_year elements code
2016/03/14  1.2.0.0 - Painting array_special_seconds, arc_battery, arc_steps
                    - Allows to create array elements with distinct colors (ie, sunday)
                    - On import from watch, install detected fonts in actual session
                    - On UI, disable properties not usables for each element 
                    - Added "Open folder" button
                    - Simulate Rotate seconds in "automatic" mode
                    - Minur issues on detecting clockskins renames and deletes
2016/03/10  1.1.1.0 - Modified behavior on rotate battery sample, assuming counterclockwise not
                    works on original engine 
2016/03/10  1.1.0.0 - Allows to reuse a rotate element, remove advertisement about this. 
                    This problem causes inconsistencies between the skin shown and saved.
                    - Includes a "simulation/now" engine (can differ from real engine)
                    - When deletes a skin, the panel not was cleared.
                    - Remove BOM mark from xml generated files.
2016/03/04  1.0.1.0 Initial publication



THANKS
==================================
Special thanks to people without whom the application would never be, 
the following active members of xda-developers community for sharing 
and explain methods for extract, build and save skins:

@Lokifish Marz
@cyrux75
@Steve Giordano (Steppdroid)

every users who have shared their creations.

...and my suffered code testers ;)
Carlos P.
Ruben G.
