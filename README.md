MyEnvelopeTester
================

Testing the theory of two envelopes with the Cover's strategy.

For more information please look:

http://en.wikipedia.org/wiki/Two_envelopes_problem

http://phys.org/news169811689.html

http://lenta.ru/news/2009/08/19/envelopes/ (russian only)

Author of idea:
===============

http://en.wikipedia.org/wiki/Thomas_M._Cover

Implementation:
===============

Roman Pushkin / code42.ru

Sample output
==============

C:\Projects3\MyEnvelopeTester\MyEnvelopeTester\bin\Debug>MyEnvelopeTester.exe <-- AlwaysFirstPicker

Your balance is: 747194283

C:\Projects3\MyEnvelopeTester\MyEnvelopeTester\bin\Debug>MyEnvelopeTester.exe <-- AlwaysSecondPicker

Your balance is: 753184502

C:\Projects3\MyEnvelopeTester\MyEnvelopeTester\bin\Debug>MyEnvelopeTester.exe <-- CoverStrategyPicker

Your balance is: 832854221

How to test
===========

Change line with the picker needed:

IPicker picker = new CoverStrategyPicker(); // change picker here

available pickers are:

* AlwaysFirstPicker
* AlwaysSecondPicker
* CoverStrategyPicker

compile the program.

