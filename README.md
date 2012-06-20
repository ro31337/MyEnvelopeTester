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
Your balance is: 7503495

C:\Projects3\MyEnvelopeTester\MyEnvelopeTester\bin\Debug>MyEnvelopeTester.exe <-- AlwaysSecondPicker
Your balance is: 7504335

C:\Projects3\MyEnvelopeTester\MyEnvelopeTester\bin\Debug>MyEnvelopeTester.exe <-- CoverStrategyPicker
Your balance is: 8886740

How to test
===========

Change line with the picker needed:

IPicker picker = new CoverStrategyPicker(); // change picker here

available pickers are:

* AlwaysFirstPicker
* AlwaysSecondPicker
* CoverStrategyPicker

compile the program.

More fun
========

Change the line at CoverStrategyPicker.cs:

int randomValue = randomProvider.Next(1, 10);

to something like

int randomValue = randomProvider.Next(1, 20);

or

int randomValue = randomProvider.Next(1, 30);

and see results!


