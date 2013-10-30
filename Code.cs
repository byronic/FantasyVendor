// TODO: Write out purchase functions (random name, random verb, random fail-to-purchase)
// TODO: Kickstarter Backer Reward - Bonus Adventures
// TODO: Halt Production option
// TODO: Add human-readable comments
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV1
{
    class Program
    {
        public static int majorversion = 1;
        public static int minorversion = 61;
        public static int lastRand = -1;
        public static bool challengeMode = false;

        static class VQueue
        {
        	public static void showMadePotion(int r)
        	{
        		switch(r)
        		{
        			case 0:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a potion!\n  ... anti-climactic.");
        				} break;
        			case 1:
        				{
        					System.Console.WriteLine("Another set of Gelatinous Glassware created by " + StoreData.pGuy + "!");
        				} break;
        			case 2:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " concocts a bewitching brew.");
        				} break;        			
        			case 3:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a tincture from a smoky cauldron! Super spooky!");
        				} break;
        			case 4:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " whips up a set of Komodo Dragon Saliva Lip Gloss!");
        				} break;
        			case 5:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " drops a fresh beat! \n  And by 'beat,' I mean 'potion.'\n    And by 'drop' I mean 'brews.'");
        				} break;
        			case 6:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " spins up a bird-buttering potion!\n  It is the most efficient method of buttering many birds in an area.");
        				} break;
        			case 7:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " mixes a Potion of Ultimate Mediocrity. \n  Truly, it is a fine thing to behold. You guess.");
        				} break;
        			case 8:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a Healing Potion!\n  You've heard those are pretty addictive.");
        				} break;
        			case 9:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a Caffeinated Potion of Speed!");
        				} break;
        			case 10:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " creates a Delicate Potion of Steely Resolve!");
        				} break;
        			case 11:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " finishes touching up a Blue Potion!\n  No idea what that does, exactly.");
        				} break;
        			case 12:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a love potion!\n  You try a small taste and receive a mouthful of infatuation.");
        				} break;        			
        			case 13:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a generic replacement for Viagra!\n  You judiciously refrain from tasting it.");
        				} break;
        			case 14:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " mixes a Potion of Undying Death!\n  You conclude it's probably better not to know why.");
        				} break;
        			case 15:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a potion of hatred!\n  Must be trouble at the ol' homestead...");
        				} break;
        			case 16:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " finishes making a case of 47 Assorted Brews and Lagers!\n  Maybe if you put a potion label on it, people will buy it anyway...");
        				} break;
        			case 17:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles an Elven Potion of Attitude!\n  The only potion made by anonymous worker drones, for elves.\n    At least, according to the ad copy.");
        				} break;
        			case 18:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " mixes up a Dwarven Potion of Height!\n  Tony the Mini-Tiger says: 'They're marrrrrrrrginally effective!'");
        				} break;
        			case 19:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " spins up a Fraught Potion with Portent!\n  James Fraught and Robert Portent will probably sue you for infringement.");
        				} break;
        			case 20:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bit-torrents a Piratical Potion!\n  It's a lot of fun, and there are no negative consequences!");
        				} break;
        			case 21:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " adds the last hint of spice to a Memory Antidote!\n  You forgot to ask why.");
        				} break;
        			case 22:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " drips the final ingredient\n  into their latest concoction with a semi-dramatic hiss!");
        				} break;        			
        			case 23:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " imagines a Potion of Wonderment into being!");
        				} break;
        			case 24:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a Potion of Thirst-Quenching!\n  It looks like water.\n    You suspect " + StoreData.pGuy + " phoned this one in.");
        				} break;
        			case 25:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a Teenage Potion of Drama Avoidance!\n  You've heard those don't actually work.");
        				} break;
        			case 26:
        				{
        					System.Console.WriteLine("The manic mind of " + StoreData.pGuy + " is hard at work,\n  brewing potions and taking names!");
        				} break;
        			case 27:
        				{
        					System.Console.WriteLine("Babbling boisterously, " + StoreData.pGuy + " bottles another bewitching brew!\n  ... my, how alliterative.");
        				} break;
        			case 28:
        				{
        					System.Console.WriteLine("Stirring feverishly, " + StoreData.pGuy + " has a serious temperature\n   above 101 degrees!\n  You'll sell the new potion anyway.");
        				} break;
        			case 29:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " is looking pretty svelte!\n  That Rapid Weight Loss Potion has some serious side effects!");
        				} break;
        			case 30:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a Boiling Potion!\n  It sounds like it will have a pretty short shelf life.\n    Although you suppose it could be re-heated at home.");
        				} break;
        			case 31:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " surreptitiously whips up a Skulking Potion!\n  You make a mental note to count up the gold an extra time tonight.");
        				} break;
        			case 32:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " mixes a potion of Extreme Depth Perception!\n  Best for use in people who forgot their contacts.");
        				} break;        			
        			case 33:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles an Elixir of Frozen Fire!\n  Perhaps the least popular wine in all the land.");
        				} break;
        			case 34:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a Firewall Brew!\n  Tasty, yet secure.");
        				} break;
        			case 35:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a Potion of Unending Madness!\n  The focus group really let you down on this one.");
        				} break;
        			case 36:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews fortune, bottles fame and stoppers death!\n  How odd.\n    You get a potion out of the deal, anyway.");
        				} break;
        			case 37:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " cans a batch of cold Green Potion!\n  How ... odd.");
        				} break;
        			case 38:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a Skull Potion of Skullduggery!\n  That doesn't feel ominous at all!");
        				} break;
        			case 39:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " drips the final piece of a Sliced Pie Potion into a pan!\n  That actually sounds pretty good.");
        				} break;
        			case 40:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a cup of coffee.\n  'We'll sell it as an Energy Brew,' " + StoreData.pGuy + " explains.");
        				} break;
        			case 41:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " mixed a Potion of Unfeeling Sympathy.\n  You've just about had it with all the contradictions around here.");
        				} break;
        			case 42:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " mixes an Invisible Potion of Invisibility!\n  You hope you can find it later.\n    You sigh at the cheap joke.");
        				} break;        			
        			case 43:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " mixes a rare potion of Nonya Business!\n  You consider your options, then choose not to ask.");
        				} break;
        			case 44:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a Big Potion!\n  'What's that one do?' you ask.\n    'Nothing. It's just big.'");
        				} break;
        			case 45:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a Steely Potion of Weakness!\n  You let it slide.");
        				} break;
        			case 46:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a Potion of Inky Blackness!\n  You suppose you did need a use for all those squid...");
        				} break;
        			case 47:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a Common Rarity Potion!\n  The possibilities are endless!\n    Or possibly very limited.");
        				} break;
        			case 48:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " brews a Potion of Hallucinogenic Goodness!\n  You tip some into your flask, for later.");
        				} break;
        			case 49:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a Sickly Potion of Cure Disease!\n  Eat that, clerics!");
        				} break;
        		}
        	}
        	public static void showFailedPotion(int r)
        	{
        		switch(r%26)
        		{
        			case 0:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " was going to make a bird-buttering potion,\n  but you don't have enough gold to buy ingredients with.");
        				} break;
        			case 1:
        				{
        					System.Console.WriteLine("There are no funds to supply " + StoreData.pGuy + "\n  with raw materials!");
        				} break;
        			case 2:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " couldn't concoct \n  a bewitching brew. It's your fault.\n    You, and your lack of gold.");
        				} break;        			
        			case 3:
        				{
        					System.Console.WriteLine(StoreData.pGuy + "'s smoky cauldron has been repossessed!\n  There will be no more potions made today.");
        				} break;
        			case 4:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " makes a new potion but you can't afford to bottle it!\n  It evaporates...");
        				} break;
        			case 5:
        				{
        					System.Console.WriteLine("You've run completely out of essence of pickled dragon!\n  " + StoreData.pGuy + " can't make anything...");
        				} break;
        			case 6:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " came up with a nifty\n  idea for a new potion. But you don't have any R&D gold left...");
        				} break;
        			case 7:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " would have mixed\n a Potion of Ultimate Mediocrity.\n    Maybe it's ok you ran out of money...");
        				} break;
        			case 8:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " can't afford to brew\n  a Healing Potion! You do your best not to think of the\n    ramifications to public health.");
        				} break;
        			case 9:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " bottles a\n  Decaffeinated Potion of Speed (since you can't afford ingredients).\n    There's no way you could ever sell this in good conscience.\n      You dump it out.");
        				} break;
        			case 10:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " twiddles thumbs.\n  You're not sure whose thumbs.");
        				} break;
        			case 11:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " can't be funded!\n  You just don't have enough gold.\n    Nothing happens.");
        				} break;
        			case 12:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " tries to brew\n  a love potion with leftover chemicals.\n    You could have done without the results.");
        				} break;        			
        			case 13:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " wants to brew\n  a Fanciful Potion, but you're out of money.");
        				} break;
        			case 14:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " is drinking on the job!\n  You can't blame them, there's no money to produce new potions...");
        				} break;
        			case 15:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " would brew a potion\n  of hatred. If there was enough gold.\n    There isn't.");
        				} break;
        			case 16:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " whines about\n  your lack of money.\n    Again.");
        				} break;
        			case 17:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " can't brew an\n  Elvish potion, what with your astounding continued lack of funds.\n    Won't someone think of the elves?\n      And their rich, gifted children?");
        				} break;
        			case 18:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " moans disconsolately\n  at your empty coffers.\n    You wish they would stop.");
        				} break;
        			case 19:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " weeps gently\n  into a beer. If only you could sell that...");
        				} break;
        			case 20:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " wishes you could\n  hire a sous chef. Sadly, there's not enough money to even\n    brew the tiniest potion.");
        				} break;
        			case 21:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " takes off the robe\n  and wizard hat. You can't afford to make more potions right now.");
        				} break;
        			case 22:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " makes a big\n  show of mixing things together, but you know better.\n    There's no money to buy ingredients.");
        				} break;        			
        			case 23:
        				{
        					System.Console.WriteLine(StoreData.pGuy + " imagines,\n  but can't bring a Potion of Wonderment into being.");
        				} break;
        			case 24:
        				{
        					System.Console.WriteLine("There's no money to brew potions right now.");
        				} break;
        			default:
        				{
        					System.Console.WriteLine("You can't afford any potion ingredients right now.");
        				} break;	
        		}
        	}
        	
        	public static void showMadeWeapon(int r)
        	{
        		switch(r)
        		{
        			case 0:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts a\n  Licorice Whip of Ultimate Comebacks. Oh, snap!!!");
        				} break;
        			case 1:
        				{
        					System.Console.WriteLine("Another fantastic pointy thing created by\n  " + StoreData.wGuy + "! Very useful for stabbing.");
        				} break;
        			case 2:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " made a Bag of Holding,\n  the Silent Killer.");
        				} break;        			
        			case 3:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " carves out a\n  +" + StoreData.wLevel + " Polesword of Silent Earth!");
        				} break;
        			case 4:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts a Polecat Sword!\n  This is indeed worrisome.");
        				} break;
        			case 5:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " drops a fresh beat! \n  And by 'beat,' I mean 'weapon.'\n    And by 'drop' I mean 'crafts.'\n       Specifically, they're an Earth-616 Lot of 7 Infinity Gems.");
        				} break;
        			case 6:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " makes a big ol'\n  Axe of Largeness! Good gravy, it's big.\n    In retrospect, you could have figured that out on your own.");
        				} break;
        			case 7:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " creates a +" + StoreData.wLevel + "\n  Mace of Love and Peace!\n    It's rather a misnomer.");
        				} break;
        			case 8:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafted a +" + StoreData.wLevel + " Bronze Polesword\n  of Grand Discovery!");
        				} break;
        			case 9:
        				{
        					System.Console.WriteLine("The flame is lit! The forge is hot! You're not sure\n  why " + StoreData.wGuy + " doesn't use them\n    while crafting another weapon. C'est la vie.");
        				} break;
        			case 10:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " forges an\n  epic item -- the hallowed Sword of Nutt.\n    You're not sure if this counts as forgery.");
        				} break;
        			case 11:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " creates a\n  Mace of Windu, which is just ridiculous.\n    You use it to hit " + StoreData.wGuy + ".");
        				} break;
        			case 12:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts a\n  Pocketsword. My, how convenient!");
        				} break;        			
        			case 13:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " forges a\n  Digital Chainaxe. You can't believe people\n    would pay money for this.");
        				} break;
        			case 14:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " creates a\n  Ball and Chainsword!\n    You decide not to ask.");
        				} break;
        			case 15:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts an Exploding Broadsword!\n  You affix the obligatory 'one use only' label.\n    Some people's children...");
        				} break;
        			case 16:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " drags in a tree branch.\n  You re-brand it as a Quarterstaff and apply a price sticker.");
        				} break;
        			case 17:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts a Large-ish Polearm\n  of Overcompensation! You are rightfully disgusted.");
        				} break;
        			case 18:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " mixes down another\n  Phat Axe! Mostly for the kids.");
        				} break;
        			case 19:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts the little-known\n  Ethereal Ghost Sword. As soon as you can find\n    it, you'll put it on the shelf.");
        				} break;
        			case 20:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " hammers out a\n  Crafty Axe of +" + StoreData.wLevel + " to Knitting.\n    You're not sure how that works, exactly.");
        				} break;
        			case 21:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " puts the finishing touches on\n  a Memory Flail of Broken Dreams!\n    It reeks of regret and lost potential.");
        				} break;
        			case 22:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " flails about!\n  In doing so, a Generic Flail was created.\n    You put it in the bargain bin.");
        				} break;        			
        			case 23:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " carefully enchants\n  a Bag of Infinite Possibilities. You suppose\n    that counts as a weapon.");
        				} break;
        			case 24:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " is hard at work,\n  crafting weapons and taking names!\n    You are all out of names.");
        				} break;
        			case 25:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " prepares a\n  Chilling Broadsword of Murderment.\n    How gauche.");
        				} break;
        			case 26:
        				{
        					System.Console.WriteLine("The manic mind of " + StoreData.wGuy + "\n  is hard at work... as far as you can tell.\n    You're no weapons expert.");
        				} break;
        			case 27:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " invented a Cannon!\n  Now, if we can invent a wheel...");
        				} break;
        			case 28:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " cranks up the heat on\n  a Heated Crabaxe of Fire!\n    A true trap for the casual browser.");
        				} break;
        			case 29:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " is looking pretty svelte!\n  Working out the kinks in a Kinky Shortsword\n    has some serious side effects!");
        				} break;
        			case 30:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " brews a Steam Shovelsword!\n  Those things don't last long...");
        				} break;
        			case 31:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " whips up a Crack-a-lackin' Whip of Merriment!\n  You make a mental note to pick one up for the ladies.");
        				} break;
        			case 32:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " puts the final touches on\n  a Twittering Broadaxe!\n    #anachronistic #hashtags #whatthefruit");
        				} break;        			
        			case 33:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts a Firewall!\n  You suppose shield-bashing is a legitimate art...");
        				} break;
        			case 34:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " hammers together a\n  Sword of Broads. You're not sure if that's sexist\n    in this context.");
        				} break;
        			case 35:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " forges a\n  Cursed Axe of Cthulhu Summoning.\n    You judiciously attach the 'For External Use Only' tag.");
        				} break;
        			case 36:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " creates a\n  Flail of Badgering! The damage it causes\n    isn't spectacular, but is certainly annoying.");
        				} break;
        			case 37:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " puts the finishing\n  touches on a set of Maces in designer colors!\n    You wrap them in plastic, which prompty melts.");
        				} break;
        			case 38:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " creates a Branching Staff\n  of Trees! This should get those environmentalists off\n    your back (it's made with Imitation Tree).");
        				} break;
        			case 39:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts a Pizza Slicer\n  of +" + StoreData.wLevel + " against ogres! You suppose, if you got\n    close enough to the ogre in question...");
        				} break;
        			case 40:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " forges a Nickelsword!\n  It can be used to nickel-and-dime the opponent\n    or slay Nickelback, in a pinch.");
        				} break;
        			case 41:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " mixes an Unknown\n  Arcane Sword of Wonderment DX Edition Plus Alpha JX Mode 9!\n    It's only compatible with the SNES.");
        				} break;
        			case 42:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts an Invisible Polearm!\n  You hope you can find it later.\n    You sigh at the cheap joke.");
        				} break;        			
        			case 43:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " forges an Airplane Wing\n  of +" + StoreData.wLevel + " Bludgeoning! This will go great on\n    someone with blue hair.");
        				} break;
        			case 44:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " creates a Bigger Axe\n  than is Strictly Necessary.\n    He who can wield it, can... uh... buy it.\n      OK, so the slogan needs work.");
        				} break;
        			case 45:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " crafts another\n  Generic Sword, Axe, Staff, or Polearm.\n    You heartily endorse this event or product.");
        				} break;
        			case 46:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " bangs out a\n  Staffaxe of Polearming.\n    That's just ridiculous.\n      And naughty.");
        				} break;
        			case 47:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " forges a Tiny Swordstaff\n  for use by smallened individuals and\n    perhaps fairies.");
        				} break;
        			case 48:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " has gone outside\n  for a smoke break, leaving behind a \n    Nicotine Axe of Potent Addiction.");
        				} break;
        			case 49:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " forges a\n  CreditSword, in which the user deals damage proportionate\n    to a charge on their credit card!\n      You wish you'd thought of it sooner.");
        				} break;
        		}
        	}
        	public static void showFailedWeapon(int r)
        	{
        		switch(r%26)
        		{
        			case 0:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " ships your pants,\n  but that doesn't do anything right now.\n    Also, it will probably get lost in transit.");
        				} break;
        			case 1:
        				{
        					System.Console.WriteLine("There are no funds to supply " + StoreData.wGuy + "\n  with raw materials!");
        				} break;
        			case 2:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " couldn't forge \n  a Cream Puff Sword. It's your fault.\n    You, and your lack of gold.");
        				} break;        			
        			case 3:
        				{
        					System.Console.WriteLine(StoreData.wGuy + "'s forge has been repossessed!\n  There will be no more weapons made today.");
        				} break;
        			case 4:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " doesn't have any\n  funds left for building, and so\n    hands you a brick.\n      This is only useful when running away!\n        You throw it out.");
        				} break;
        			case 5:
        				{
        					System.Console.WriteLine("You've run completely out of essence of centaur hooves!\n  " + StoreData.wGuy + " can't make anything...\n    Apparently that's a weapon ingredient.");
        				} break;
        			case 6:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " came up with a nifty\n  idea for a new poleaxe. But you don't have enough gold...");
        				} break;
        			case 7:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " would have forged\n an Axe of Sexy Studliness for girls.\n    Maybe it's ok you ran out of money...");
        				} break;
        			case 8:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " can't afford to forge!\n  That sort of rhymes. You need\n    a hip-hop artist. Stat!");
        				} break;
        			case 9:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " would have forged\n  a Broadpolesword of Greater Unfulfillment.\n    But, you're out of money!");
        				} break;
        			case 10:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " can't believe you're\n  out of gold. So much for that Poleboat of Greater Swording.");
        				} break;
        			case 11:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " can't build anything!\n  You don't have enough gold.\n    Nothing happens.\n      What a waste of a status message.");
        				} break;
        			case 12:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " wants to produce\n  a Motion Picture Blade, but you're out of gold.\n    The unwelcome advances of a fan movement are in your future.");
        				} break;        			
        			case 13:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " wants to make\n  a Flipsword of Pocketing, but you're out of money.\n    Is that ironic? You're never sure.");
        				} break;
        			case 14:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " can't forge\n  a Broadshield of High Defense. On the positive side,\n    you're not sure how to market those anyway.");
        				} break;
        			case 15:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " would have created\n  a Poleaxe of Relativity, but you don't have the gold\n    to purchase the requisite Einsteinian engine.");
        				} break;
        			case 16:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " wants to make\n  a Lovesword of Romantic Comedies,\n    but you can't afford so much as a romantic misunderstanding.");
        				} break;
        			case 17:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " can't craft an\n  Elvish Polebow, in part due to their lack of elvish\n    heritage, and in part due to your continued lack of funds.");
        				} break;
        			case 18:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " can't forge\n  a Boxcutter of Varying Effectiveness, mostly\n    due to your lack of funds.\n      Also because they are banned.");
        				} break;
        			case 19:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " wants to forge\n  a Heavy-handed Axe of Situation Comedies!\n    Unfortunately, you don't have enough funds,\n      and it won't be green-lighted by the networks.");
        				} break;
        			case 20:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " imagines a\n  Pocketsword, since you can't afford to forge another.");
        				} break;
        			case 21:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " can't afford to build\n  a big bag of axes. That seems kind of weird, anyway.");
        				} break;
        			case 22:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " makes a big show\n  of heating up the forge and putting on welder's goggles,\n    but you know better. There's no money to craft new weapons.");
        				} break;        			
        			case 23:
        				{
        					System.Console.WriteLine(StoreData.wGuy + " wishes to create\n  a Poleaxe of Sensitivity. There's not enough money,\n    and you're not even sure it's possible anyway.");
        				} break;
        			case 24:
        				{
        					System.Console.WriteLine("There's no money to craft weapons right now.");
        				} break;
        			default:
        				{
        					System.Console.WriteLine("You can't afford any weapon components right now.");
        				} break;
        		}
        	}
        	
        	public static void showMadeSteed(int r)
        	{
        		switch(r)
        		{
        			case 0:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased a\n  nifty Silvertaur. You can get hurt riding on those things!");
        				} break;
        			case 1:
        				{
        					System.Console.WriteLine("The Head of Vecna was captured by\n  " + StoreData.sGuy + "! Very useful for riding.\n    You suppose.");
        				} break;
        			case 2:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  real-io, cool-io, true-lio dragon.\n    You will be pleased to be rid-io of it.");
        				} break;        			
        			case 3:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " captured\n  Alison's Unicorn-Knitted Mustached Potato-Eating Turtle-Cat!\n    How... unusual.");
        				} break;
        			case 4:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased a\n  Threadbare Riding Carpet. You'll tell everyone it's Persian.");
        				} break;
        			case 5:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  Boulder of Speed.");
        				} break;
        			case 6:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased an\n  Enormous Cackling Twelve-Tentacled Bumbershoot,\n complete with saddle and harness.\n    You feel a little less sane just from looking at it.");
        				} break;
        			case 7:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " captured a\n  Fiery Riding Carpet of Fire!\n    It is, in point of fact, aflame.\n      You'll need to pack some lotion for those burns.");
        				} break;
        			case 8:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  Beautiful Aqua-horse, complete with sunroof and power doors.\n    Attaching a price tag to this aqueous being may prove difficult.");
        				} break;
        			case 9:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found a\n  Ginormous Riding Dog! It is larger than an enormous\n    dog but smaller than a collosal one.");
        				} break;
        			case 10:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased a\n  Fancy Horse! You can tell it's fancy because of\n    the top hat and monocle.\n      And its copy of Horse Gentleman's Quarterly.");
        				} break;
        			case 11:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " captured a\n  Ravenous Bugblatter Beast of Traal!\n  How... utterly inappropriate for the setting.");
        				} break;
        			case 12:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found a\n  Pockethorse! It's not very convenient, and difficult\n    to ride. You'll sell it anyway.");
        				} break;        			
        			case 13:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  Chaos Horse of Doom! This would be a great opportunity to\n    market to the evil-overlord demographic.\n      You laugh gleefully.");
        				} break;
        			case 14:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found a\n  Roller Derby Girl. She quickly asserts herself and proclaims she\n    won't leave until she finds the right customer.");
        				} break;
        			case 15:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " delivers a\n  Trojan Horse! At first you weren't sure what family planning and steeds\n    had in common. You still aren't.");
        				} break;
        			case 16:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " drags in a tree branch.\n  You re-brand it as a Telekinetic Hobby-Horse and apply a price sticker.");
        				} break;
        			case 17:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " bought a\n  Large Magic Carpet of Humming and Overcompensation!\n    It is the only magic carpet that requires fuel.\n        You are rightfully disgusted.");
        				} break;
        			case 18:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  Regular Ordinary Pegasus -- a 1360's vintage muscle-mount.");
        				} break;
        			case 19:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found the little-known\n  Ethereal Ghost Turtle mount. As soon as you can find\n    it, you'll put it up for sale.");
        				} break;
        			case 20:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased a\n  Blue Windsteed with a built-in +" + StoreData.sLevel + " Sorcerous Positioning System.\n    The ad copy practically writes itself.");
        				} break;
        			case 21:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found a\n  state-of-the-art Modern Horse comprised entirely\n    of juxtaposed horses created prior to Modernity.");
        				} break;
        			case 22:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  Dollar Horse! They cost more to keep than to purchase.\n    You sigh and drop it in the bargain bin.");
        				} break;        		
        			case 23:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  bucket. " + StoreData.sGuy + " assured you it is indeed useful as a mount.\n    Nevertheless, you remain dubious.");
        				} break;
        			case 24:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " is hard at work,\n  haggling, baggling, and other mount-related endeavors!\n    You avert your eyes.");
        				} break;
        			case 25:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquires a\n  Miniature Cornish Dragon with Exhaust Stylings and Hella Sweet flames\n    painted on the side.");
        				} break;
        			case 26:
        				{
        					System.Console.WriteLine("The manic mind of " + StoreData.sGuy + "\n  is hard at work... as far as you can tell.\n    You're no expert on steeds.");
        				} break;
        			case 27:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " invented a Clusterhorse!\n  Those things are seriously messed up.");
        				} break;
        			case 28:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " forges an\n  Iron Steed of Superficial Quickness! As far as you can tell,\n    it doesn't move at all. The sleek iron exterior is certainly shiny, though.");
        				} break;
        			case 29:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " has acquired\n  a jar of Mount-and-Blade Fever.\n    You shrug and dutifully place the price sticker.");
        				} break;
        			case 30:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " has acquired\n  a Riding Cactus! Multiple attempts to approach it faze you.\n  Seems this fellow will have to be price-available-on-request.");
        				} break;
        			case 31:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " has a serious liver condition.\n  Thanks to your no-right-to-leave-work policy, you still manage\n    to acquire a new steed.");
        				} break;
        			case 32:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " picked up\n  a Centaur-of-the-Night. Due to circumstances beyond anyone's control\n    he is now for sale in your shop.\n      Hey, I'm just as confused as you.");
        				} break;        			
        			case 33:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  Small Sorcerous Orb. You suppose a well-balanced person could\n    ride it effectively.");
        				} break;
        			case 34:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found a\n  horse, but it looks to you like it's two people from the carnival sack race\n    tied together. They make no objection to being sold, however.");
        				} break;
        			case 35:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  Cursed Daemon-Steed of Pummeling, Biting,\n    Scratching and Generally Being an Ass.\n    You judiciously attach the 'For External Use Only' tag.");
        				} break;
        			case 36:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased a\n  Badger Mount! You're tempted to take it home yourself, but to be honest\n    you have no earthly idea how to care for a badger.");
        				} break;
        			case 37:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " has written\n  a dirty limerick onto a sheet of paper. Far be it from you\n    to debate the merits of mount-acquiring and steed-shuffling,\n      but you can't figure out how the process acquired another steed.");
        				} break;
        			case 38:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " is large\n  and in charge! Also, a Rollicking Tornado Mount was added to your stock.\n    You are not yet certain if these events are related.");
        				} break;
        			case 39:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " has purchased\n  the dreaded Land-Fish! For those who can master\n   its scaly slipperiness, the Land-Fish\n    is an effective and fun mount for the whole family,\n      provided said family is aquatic. And very patient.");
        				} break;
        			case 40:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased\n  the Lone Locust of the Apocalypse. There are an awful lot of these,\n    and you're not sure how useful one would be as a mount.");
        				} break;
        			case 41:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found\n  yet another horse. What a freakin' surprise. You feign surprise.\n    No one is fooled.");
        				} break;
        			case 42:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found a\n  White Elephant! You refrain from commenting on the elephant in the room.");
        				} break;        			
        			case 43:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " forges an Airplane Wing\n  of +" + StoreData.sLevel + " Moving! This would be a great mount for\n    someone with blue hair.");
        				} break;
        			case 44:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased a Mount\n in a Stone. He or she who can pull the mount from the stone,\n      will be forced to purchase it or become King/Queen of England.\n        You're not exactly sure.");
        				} break;
        			case 45:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased another\n  Magic Carpet, Horse, Exotic Mount, or Outlandish Steed.\n    You can't expect to know all the daily dealings of your workers.");
        				} break;
        			case 46:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " found a\n  +6 Horse of Polar Banditry.\n    That's just ridiculous.\n      And it would work better if it used Cartesian coordinates.");
        				} break;
        			case 47:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " purchased an Eensy Dragon\n  for use by smallened individuals and\n    perhaps fairies.");
        				} break;
        			case 48:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " has gone outside\n  for a smoke break, leaving behind a \n    Ride-able Poisonous Arachnid who is Too Cool for School.\n    On further inspection, you find its GED.");
        				} break;
        			default:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " acquired a\n  CreditSteed, in which the user can fly quickly, in proportion\n    to a charge on their credit card!\n      You can hear gold chinking with each clop.");
        				} break;
        			}
        		}
        	public static void showFailedSteed(int r)
        	{
        		switch(r%26)
        		{
        			case 0:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " is watching\n  highlights on Cabalvision. You don't have any money\n    to buy new steeds with, anyway.");
        				} break;
        			case 1:
        				{
        					System.Console.WriteLine("There are no funds to put " + StoreData.sGuy + "\n  out on the road to search for mounts!");
        				} break;
        			case 2:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " couldn't purchase \n  a Seriously Exquisite Dragon of Jaw-Dropping Beauty. It's your fault.\n    You, and your lack of gold.");
        				} break;        			
        			case 3:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " is nowhere to be found!\n  There's no money to purchase steeds with anyway.");
        				} break;
        			case 4:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " doesn't have any\n  funds left, and so hands you a stick-figure drawing of a turtle.\n      This makes less sense than you expected.\n        Time to get some money for the food budget.");
        				} break;
        			case 5:
        				{
        					System.Console.WriteLine("You've run completely out of essence of irony!\n  " + StoreData.sGuy + " can't buy anything...\n    Apparently that's something steed experts need.");
        				} break;
        			case 6:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " was going to buy a\n  Kick-Ass Magic Carpet, but your lack of gold scuppered the negotiations.");
        				} break;
        			case 7:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " would have bought\n a High-Maintenance Longhorse.\n    Maybe it's ok you ran out of money...");
        				} break;
        			case 8:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " hands you a sheet of paper.\n  You read: 'horses are red, i'm seriously blue\n    where the hell is the money to buy stuff with.'\n      Subtle and artsy, but you get the message.");
        				} break;
        			case 9:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " had eyes on \n  a Fanatical Steed of a Thousand Legs!\n    You're not sure you could have sold something that creepy...");
        				} break;
        			case 10:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " can't believe you're\n  out of gold. So much for that Yachthorse of Lesser Swimming.");
        				} break;
        			case 11:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " can't buy anything!\n  You don't have enough gold.\n    Nothing happens.\n      What a waste of a status message.");
        				} break;
        			case 12:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " wants to buy\n  a Motion Picture Were-horse, but you're out of gold.\n    The unwelcome advances of a fan movement are in your future.");
        				} break;        			
        			case 13:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " wants to acquire\n  a Pockethorse, but you're out of money.\n    Is that pathos? You're never sure.");
        				} break;
        			case 14:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " is seriously blue\n  about not being able to buy anything. Or maybe choking\n    on a chicken bone. It's hard to say and you've no desire\n      to find out.");
        				} break;
        			case 15:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " can't afford\n  even the most basic Regular Ordinary Horse right now.\n    You would break down into tears but you're not sure if doing\n  so is taxable. You play it safe.");
        				} break;
        			case 16:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " wants to buy\n  a Ride-able Love Day Heart,\n    but you can't afford so much as a romantic misunderstanding.");
        				} break;
        			case 17:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " couldn't strike a deal\n  with the Horse Conglomerate. This is partially due to a lack of skill\n    but mostly due to your lack of funds.");
        				} break;
        			case 18:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " can't purchase\n  a Class-D Untradeable Horse.\n    You're no detective, but you suspect this is\n      due to your lack of funds.");
        				} break;
        			case 19:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " imagines purchasing\n  a Well-To-Do Enchanted Broadhorse.\n    Ah, if only you had gold...");
        				} break;
        			case 20:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " wishes very, very hard\n  for enough money to enter into steed negotiations.\n    As with all wishes made on a moonlit night on\n      the first star you see, nothing happens.\n        Just like with your parents.");
        				} break;
        			case 21:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " wanted to buy\n  a Bag of Dragons. You're sort of grateful\n  a lack of gold scuppered the transaction.");
        				} break;
        			case 22:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " makes a big show\n  of drawing up contracts and wearing a 10-gallon hat,\n    but you know better. There's no money to buy anything.");
        				} break;        			
        			case 23:
        				{
        					System.Console.WriteLine(StoreData.sGuy + " puts together a Toothpick Horse,\n  but in your excitement you've broken it under your foot.");
        				} break;
        			case 24:
        				{
        					System.Console.WriteLine("There's no money to purchase steeds right now.");
        				} break;
        			default:
        				{
        					System.Console.WriteLine("You can't afford any steed negotiations right now.");
        				} break;
        		}
        	}
        	
        	/// <summary>
        	///  shows a customer interaction, with purchasing.
        	/// </summary>
        	/// <param name="stock">Is the item in stock?</param>
        	/// <param name="type">Type of item: 0=potion, 1=weapon, 2=steed</param>
        	public static void showCustomerInteraction(bool stock, int type)
        	{
        		string sentence = "";
        		/*
        		 *  Types of random sentences we construct
        		 * <prepositional phrase/preamble> -- sometimes blank, for variety
        		 * <name>
        		 * <verb>
        		 * <item>
        		 * <conclude sentence> -- sometimes blank, for variety... or perhaps not
        		 *  pseudo-code example, spaces and syntax not correct:
        		 *  'although appearing tired and/or homeless,' + 'Dr. Sleep' + 'buys the hell out of' + 'a Serious Weapon.' + 'What a weirdo!'
        		 *    ^ this is also lame, even by your standards. Fix it! Funny examples are a must.
        		 * */
        		// remember -- StoreData.r is where you've hidden the random number generator
        		
        		sentence += StoreData.preamble[StoreData.r.Next(0,StoreData.preamble.Length)];
        		if(sentence != "")
        			sentence += "\n ";
        		
        		sentence += StoreData.customerName[StoreData.r.Next(0,StoreData.customerName.Length)];
        		 //in case of empty pre-amble, upper-case the first letter. If a preamble was there, it's already upper-cased so no harm done...
        		 //  if a preamble isn't there, the customer's name isn't necessarily capitalized to start, so upper-casing the first letter fixes that
        		 sentence = sentence.First().ToString().ToUpper() + String.Join("", sentence.Skip(1));
        		 
        		
        		if(stock)
        			sentence += StoreData.verb[StoreData.r.Next(0,StoreData.verb.Length)]  + "\n  ";
        		else
        			sentence += StoreData.badVerb[StoreData.r.Next(0,StoreData.badVerb.Length)]  + "\n  ";
        		

        		
        		switch(type)
        		{
        			case 0: // potion
        				sentence += StoreData.potion[StoreData.r.Next(0,StoreData.potion.Length)]  + "\n   ";
        				break;
        			case 1: // weapon
        				sentence += StoreData.weapon[StoreData.r.Next(0,StoreData.weapon.Length)]  + "\n   ";
        				break;
        			case 2: // steed
        				sentence += StoreData.steed[StoreData.r.Next(0,StoreData.steed.Length)]  + "\n   ";
        				break;
        			default: sentence += "an item that may never have existed."  + "\n   ";
        				break;
        		}
        		
        		if(stock)
        			sentence += StoreData.conclusion[StoreData.r.Next(0,StoreData.conclusion.Length)]  + "\n    ";
        		else
        			sentence += StoreData.badConclusion[StoreData.r.Next(0,StoreData.badConclusion.Length)]  + "\n    ";
        		// the sentence is constructed! display it, you hoodlum
        		System.Console.Write(sentence);
        	}
        	
        	public static void showFreeloader()
        	{
        		string sentence = "";
        		sentence += StoreData.preamble[StoreData.r.Next(0,StoreData.preamble.Length)];
        		if(sentence != "")
        			sentence += "\n ";
        		
        		sentence += StoreData.customerName[StoreData.r.Next(0,StoreData.customerName.Length)] + "\n  ";
        		 //in case of empty pre-amble, upper-case the first letter. If a preamble was there, it's already upper-cased so no harm done...
        		 //  if a preamble isn't there, the customer's name isn't necessarily capitalized to start, so upper-casing the first letter fixes that
        		 sentence = sentence.First().ToString().ToUpper() + String.Join("", sentence.Skip(1));
        		 
        		 
        		 switch(StoreData.r.Next(0, 10))
        		 {
        		 	case 0:
        		 		sentence += "is just here to hang out. What a load!";
        		 		break;
        		 	case 1:
        		 		sentence += "hangs around for awhile, then leaves without buying anything.";
        		 		break;
        		 	case 2:
        		 		sentence += "eats, shoots and leaves. You feel like something went wrong there.";
        		 		break;
        		 	case 3:
        		 		sentence += "paws through your wares, then exits hurriedly when you ask if you can help.";
        		 		break;
        		 	case 4:
        		 		sentence += "doesn't even buy anything! What a rip.";
        		 		break;
        		 	case 5:
        		 		sentence += "left before you could ask what was needful.\n    Probably wasn't going to buy, anyway...";
        		 		break;
        		 	case 6:
        		 		sentence += "already made purchases across town. You're not surprised at the NO SALE.";
        		 		break;
        		 	case 7:
        		 		sentence += "didn't see anything useful to purchase.";
        		 		break;
        		 	case 8:
        		 		sentence += "hangs around for awhile, then leaves before you notice.";
        		 		break;
        		 	case 9:
        		 		sentence += "does whatever a non-paying customer does. What a rip!";
        		 		break;
        		 	default:
        		 		sentence += "never came into the store at all. Something odd happened.";
        		 		break;
        		 }
        		 
        		 System.Console.Write(sentence);
        	}
        	
            public static void queue(int msg, int param)
            {
                // clear and show status
                showStatus();
				
                int msgnum;
                
                do
				{
                msgnum = StoreData.r.Next(0, 49); // 50 possible messages per event -- if you want more, change these values!
				} while(msgnum == lastRand); // make sure we got a different event than the last time
				lastRand = msgnum;
				
                switch (msg)
                {
                    case 0: // made a potion!
                        {
                			showMadePotion(msgnum);
                        } break;
                    case 1: // tried to make a potion but didn't have enough gold to buy ingredients!
                        {
                			showFailedPotion(msgnum);
                        } break;
                    case 2: // made a weapon!
                        {
                			showMadeWeapon(msgnum);
                        } break; // licorice whip of witty comebacks. Oh, snap!
                    case 3: // tried to make a weapon but didn't have enough gold
                        {
                			showFailedWeapon(msgnum);
                        } break; // +4 Lead Wrench of Lesser Mediocrity
                    case 4: // made a steed!
                        {
                			showMadeSteed(msgnum);
                        } break;
                    case 5: // tried to acquire steed but not enough gold
                        {
                			showFailedSteed(msgnum);
                        } break;
                    case 6: // manufacturing time is over, time to throw open the doors to a new day!
                        {
                            System.Console.WriteLine("\nThe doors are opened and customers begin to arrive!\n");
                        } break;
                    case 7: // buy a potion
                        {
                			showCustomerInteraction( true, 0 );
                        } break;
                    case 8: // want to buy a potion but out of stock
                        {
                			showCustomerInteraction( false, 0 );
                        } break;
                    case 9: // buy a weapon
                        {
                			showCustomerInteraction( true, 1 );
                        } break; // Finely Honed Throwing Bologna
                    case 10: // want to buy a weapon but out of stock
                        {
                			showCustomerInteraction( false, 1 );
                        } break;
                    case 11: // buys a steed
                        {
                			showCustomerInteraction( true, 2 );
                        } break;
                    case 12: // wants to buy a steed but out of stock
                        {
                			showCustomerInteraction( false, 2 );
                        } break;
                    case 13: // customer just came to look around
                        {
                			showFreeloader();
                        } break;
                	case 14: // end of day report!
                		{
                			System.Console.WriteLine("The day has ended!\n  You made " + StoreData.pMade + " new potions, " + StoreData.wMade + " new weapons and acquired " + StoreData.sMade + " new steeds.\n    You sold " + StoreData.pSold + " potions, " + StoreData.wSold + " weapons, and " + StoreData.sSold + " steeds.\n");
                		} break;
                    default:
                        {
                            System.Console.WriteLine(".error. Sorry, I'm not sure what was supposed to happen here.\n  Something went wrong. :( ");
                        }  break;
                }
                System.Console.WriteLine("\nPress a key to continue...");
                System.Console.ReadKey(true);
                
            }
        }
        	
        	

        static class StoreData
        {
            // Randomizer
            public static Random r = new Random();

            // store gold
            public static int gp = 5; // your store begins play with 5 gold

            // store information
            public static string name = ".error. no name";
            public static int day = 0; // we also use this to do rent calculations

            // store manufacturer guys -- if empty string, you don't have that guy
            public static string pGuy = "";
            public static string wGuy = "";
            public static string sGuy = "";

            // store stock, and level (multiplies cost to make and sell price)
            public static int potions = 0;
            public static int weapons = 0;
            public static int steeds = 0;
            public static int pLevel = 1;
            public static int wLevel = 1;
            public static int sLevel = 1;

            public static int leveledUp = 0; // number of times leveled up
            
            public static int pMade, pSold, wMade, wSold, sMade, sSold;
#region names, arrays, sentence structure       
            // names, arrays, sentence structure
            
            public static string[] badVerb = 
            { 
            	"would have bought the hell out of ",
    			"would have purchased ",
    			"wanted to acquire ",
    			"was looking to get ",
    			"would have bought ",
    			"wanted ",
    			"wished to obtain ",
    			"would have paid for ",
    			"had brought enough pennies for ",
    			"wanted to snaffle "}; //end string[] badVerb definition
            
            public static string[] badConclusion = { "But you were out of stock!",
        			"You are out of stock of that item type!",
        			"Damn, no stock!",
        			"But, there's no stock to be had!",
        			"If only you had one to sell!",
        			"You curse at your lack of inventory.",
        			"You dream of the profits that could have been made.",
        			"Your attempt to stifle sobs fails miserably.",
        			"\"I DON'T HAVE ANY, SHUT UP!\" You shout.",
        			"\"NOOOOOOOO!\" You adamantly proclaim.",
        			"You heave a great sigh, and look in all the corners of the room.\n   If only you had that in stock...",
        			"You really picked a hell of a week to quit drinking.",
        			"Just wait 'til the union hears about your lack of stock.",
        		};
            
            public static string[] steed = 
			{
			"Alison's Unicorn-Knitted Mustached Potato-Eating Turtle-Cat!",
			"The Head of Vecna, inexplicably rideable.",			
            "a nifty Silvertaur!",
			"an improbable beast.",
			"a real-io, cool-io, true-lio dragon.",
			"an Elemental Polecat of Expert Riding!",
			"a Threadbare Riding Carpet.",
			"a Boulder of Speed.",
			"an Enormous Cackling Twelve-tentacled Bumbershoot (with saddle and harness attachments).",
			"a Fiery Riding Carpet of Fire!",
			"a Beautiful Aqua-Horse.",
			"a Ginormous Riding Dog!",
			"a Fancy Horse.",
			"a Ravenous Bugblatter Beast of Traal!",
			"a Pockethorse.",
			"a Chaos Horse of Doom.",
			"a Roller Derby Girl.",
			"a Trojan Horse.",
			"a Telekinetic Hobby-Horse.",
			"a Large Magic Carpet of Humming and Overcompensation!",
			"an Ethereal Ghost Turtle.",
			"a Regular Ordinary Pegasus.",
			"a Blue Windsteed.",
			"a state-of-the-art Modern Horse.",
			"a Dollar Horse.",
			"a bucket, usable as a mount.",
			"a mount-related item.",
			"a Miniature Cornish Dragon with Exhaust Stylings.",
			"a Clusterhorse!",
			"an Iron Steed of Superficial Quickness.",
			"a Mount-and-Blade Feversteed.",
			"a Riding Cactus!",
			"a Centaur-of-the-Night.",
			"a Small Sorcerous Orb.",
			"a \"horse,\" according to the label.",
			"a Cursed Daemon-Steed of Generally Being an Ass.",
			"a Badger Mount.",
			"a Rollicking Tornado Mount.",
			"the dreaded Land-Fish!",
			"the Lone Locust of the Apocalypse.",
			"yet another horse.",
			"a White Elephant!",
			"the Mount in the Stone.",
			"an Outlandish Steed of some sort.",
			"a +6 Horse of Polar Banditry.",
			"an Eensy Dragon.",
			"a Ride-able Poisonous Arachnid.",
			"a Creditsteed."
			}; // end string[] steed definition
            
            public static string[] weapon = 
			{ 
            "the legendary Sword of Nutt.",
			"Earth-616 Lot of 7 Infinity Gems --\n   Soul, Power, Time, Space, Mind, Reality and Ego.",            
            "a Licorice Whip of Ultimate Comebacks.",
			"some kind of pointy thing.",
			"a Bag of Holding.",
			"a Polesword of Silent Earth!",
			"a Polecat Sword.",
			"an Axe of Largeness!",
			"a Mace of Love and Peace!",
			"a Bronze Polesword of Grand Discovery!",
			"a Fancy Intermediate Sword of Variable Length.",
			"a Mace of Windu.",
			"a Pocketsword.",
			"a Digital Chainaxe.",
			"a Ball and Chainsword!",
			"an Exploding Broadsword.",
			"a Buck-and-a-quarter Quarter Staff.",
			"a largeish Polearm of Overcompensation.",
			"an Ethereal Ghost Sword.",
			"a Phat Axe.",
			"a Crafty Axe with a Knitting bonus.",
			"a Memory Flail of Broken Dreams.",
			"a Bag of Infinite Possibilities.",
			"a Chilling Broadsword of Murderment.",
			"a Cannon!",
			"a Heated Crabaxe of Fire.",
			"a Kinky Shortsword.",
			"a Steam Shovelsword!",
			"a Crack-a-lackin' Whip of Merriment.",
			"a Twittering Broadaxe.",
			"a Firewall.",
			"a Cursed Axe of Cthulhu Summoning.",
			"a Flail of Badgering.",
			"a Mace in designer colors!",
			"a Branching Staff of Trees (made with imitation tree).",
			"a Pizza Slicer.",
			"a Nickelsword!",
			"an Unknown Arcane Sword of Wonderment DX Edition Plus Alpha JX Mode 9!",
			"an Invisible Polearm!",
			"an Airplane Wing!",
			"a Bigger Axe than is Strictly Necessary.",
			"a Generic Sword, Axe, Staff or Polearm.",
			"a Tiny Swordstaff.",
			"a Nicotine Axe of Potent Addiction.",
			"a Creditsword.",
			"Komodo Dragon Saliva Lip Gloss."
			}; // end string[] weapon definition
            
            public static string[] potion = 
				{ 
            	"a set of Gelatinous Glassware.",
            	"Komodo Dragon Saliva Lip Gloss.",
            	"a tincture.",
				"a potion.",
				"a bird-buttering potion!",
				"a Potion of Ultimate Mediocrity!",
				"a Healing Potion.",
				"a Caffeinated Potion of Speed.",
				"a Delicate Potion of Steely Resolve.",
				"a Blue Potion!",
				"a love potion.",
				"a generic replacement for Viagra!",
				"a Potion of Undying Death!",
				"a potion of hatred.",
				"47 Assorted Brews and Lagers!",
				"an Elven Potion of Attitude.",
				"a Dwarven Potion of Height.",
				"a Fraught Potion with Portent!",
				"a Piratical Potion.",
				"a Memory Antidote!",
				"a frothy concoction.",
				"a Potion of Wonderment.",
				"a Potion of Thirst-Quenching (a.k.a. water)!",
				"a Teenage Potion of Drama Avoidance.",
				"a Circular Potion.",
				"a Bewitching Brew!",
				"a Feverish Frothy Potion of Fright!",
				"a Rapid Weight Loss Potion.",
				"a Boiling Potion, handling it very carefully.",
				"a Skulking Potion.",
				"a Potion of Extreme Depth Perception!",
				"an Elixir of Frozen Fire!",
				"a Firewall Brew!",
				"a Potion of Unending Madness!",
				"Fortune Brew.",
				"Bottled Fame.",
				"Stoppered Death.",
				"ice-cold Green Potion.",
				"a Skull Potion of Skullduggery.",
				"a Sliced Pie Potion.",
				"a cup of coffee masquerading as Energy Brew.",
				"a Potion of Unfeeling Sympathy.",
				"an Invisible Potion of Invisibility.",
				"a Potion of Nonya Business.",
				"a Big Potion.",
				"a Steely Potion of Weakness!",
				"a Potion of Inky Blackness.",
				"a Common Rarity Potion!",
				"a Potion of Hallucinogenic Goodness!",
				"a Sickly Potion of Cure Disease!"
				}; // end string[] potion definition
            
                    		// 30 total conclusions
        		public static string[] conclusion = { "",
        			"",
        			"What a weirdo!",
        			"What a mouth-breather!",
        			"Interesting...",
        			"You're not sure what to make of that.",
        			"You gleefully accept the profits while trying to stifle laughter.",
        			"Your attempt to stifle maniacal laughter fails miserably.",
        			"\"NO REFUNDS!\" You shout.",
        			"\"NO TAKEBACKS!\" You adamantly proclaim.",
        			"The day just seems to get weird around 3 PM.",
        			"Don't any of these people have jobs?",
        			"There's no accounting for taste,\n     but if there were this would be super costly.",
        			"They were probably underage, but you're not sure if it's legal either way.",
        			"Recklessly, you autograph it.",
        			"Wisely, you decide not to ruminate on why.",
        			"Your attention is consumed by sandwiches during the transaction.\n   Can they really be as witchly as the name suggests?",
        			"This distracts you momentarily from the group suicide pact\n   currently taking place in the square outside.",
        			"Passersby are amazed at the unusually large amounts of blood.",
        			"You get the mop.",
        			"You sigh, and clean up afterwards.",
        			"You heave a great sigh, and look in all the corners of the room.\n   If only there were a group murder-suicide pact you could join...",
        			"You're too busy concentrating on growing a beard to pay this much attention.",
        			"You really picked a hell of a week to quit drinking.",
        			"The vinyl figurine collection you left in the window remains undisturbed.",
        			"Just wait 'til the union hears about this.",
        			"\"One more for the meat-grinder,\" goes the old saying.\n   You wish you knew what it meant.",
        			"",
        			"",
        			"",
        		};
        		
        		// 10 total verbs
        		public static string[] verb = { "buys the hell out of ",
        			"purchases ",
        			"acquires ",
        			"picks out ",
        			"buys ",
        			"wants ",
        			"gets ",
        			"pays for ",
        			"counts out enough pennies to get ",
        			"nabs "
        		}; // end string[] verbs definition
        		
        		// 36 total names
        		public static string[] customerName = { 
        			"Thifel Gimdek ",
        			"Dudley the Squire ",
        			"Cory Watson ",
        			"Dimply Death Shade ",
        			"Developer's Choice, the Non-Preferential ",
        			"Kristen, Keeper of the Deluxe Edition ",
        			"Arisu ",
        			"Byro ",
        			"Little Miss Crapplebottom ",
        			"Dr. Sleep ",
        			"Rodney Q. Flattwilder ",
        			"I.P. Jokes ",
        			"Newt 'Newt' Newtberg ",
        			"Sensor Shippes ",
        			"an Unnamed Government Operative (Richard Tutwiler) ",
        			"Brenton Chang, The Head of Her Majesty's Secret Service (TODO: remove this part) ",
        			"Albert Schweitzer (a dated reference by anyone's standards) ",
        			"the King of Mayors ",
        			"Krissward ",
        			"a minor deity ",
        			"a slightly less-than-minor deity ",
        			"a complete nonentity ",
        			"a flamboyant ninja ",
        			"elusive rockstar David Bowie himself ",
        			"Pillbo ",
        			"A VERY LARGE ANT ",
        			"slick radio announcer Chet Chetley ",
        			"bewildered political cartoonist Stant Scottis ",
        			"the entire squad of the 1980 New York Knicks ",
        			"a sentient bag of rocks ",
        			"eyebrow salesman Briggs Briggerson ",
        			"famed philosopher Local Woman ",
        			"Dirk Gently ",
        			"a mysterious pirate ",
        			"real estate magnate Isolde Proputty ",
        			"horrible pun generator Stig Stevebert ",
        			"Famous Jame-us (whom you've never heard of) ",
        			"Mark ",
        			"Jim ",
        			"Janein ", // TODO: CHECK THIS FOR ACCURACY YOU DINGBAT
        			"a group comprised of all the Kickstarter backers\n  who assisted in the creation of this game ",
        			"Bill the real-life statistical anomaly "
        		}; // end string[] name definition
        			
        			
        		
        		// 25 total preambles
        		public static string[] preamble = { "", 
        			"Although appearing tired and/or homeless, ",
        			"Despite an obvious propensity for anti-consumerism, ",
        			"After wandering for a seemingly interminable time, ",
        			"",
        			"",
        			"Shouting all the while, ",
        			"Obviously unfazed by a mild case of death, ",
        			"Clucking like a sales-mad chicken, ",
        			"",
        			"",
        			"Disconsolately sipping on a large mocha of some kind, ",
        			"Adorned in the garb of the local clergy, ",
        			"Resolutely stomping about the store in stolen boots, ",
        			"Forgetting completely that the stove at home is on, ",
        			"Repeatedly reminding everyone \"I KNOW MY RIGHTS AS A CONSUMER,\" ",
        			"Clad in merely a banana skin, ",
        			"After a long meander, a short idle, and a brief fling with destiny, ",
        			"Alongside an entire sock collection, ",
        			"Fresh from work, ",
        			"",
        			"Blue as a shoe, ",
        			"Chewing animatedly on a pile of rocks, ",
        			"Crying inconsolably, ",
        			"Consumed with secret shame, ",
	        		}; // end string[] preamble definition
            
#endregion 
            // random no. of AI customers choose to buy, or not buy, items
            public static void generateStoreDay()
            {
                // number of items made and sold today
                pMade = pSold = wMade = wSold = sMade = sSold = 0;

                // make items!
                if (pGuy != "")
                {
                    int tryMake = r.Next(1, pLevel + 3);
                    for (int i = 0; i < tryMake; i++)
                    {
                        if (gp >= pLevel)
                        {
                            gp -= pLevel;
                            pMade++;
                            potions++;
                            // made a potion!
                            VQueue.queue(0, 0);
                        }
                        else
                        {
                            //tried to make a potion but not enough gold to buy ingredients!
                            VQueue.queue(1, 0);
                            break;
                        }
                    }
                }
                if (wGuy != "")
                {
                    int tryMake = r.Next(1, wLevel + 3);
                    for (int i = 0; i < tryMake; i++)
                    {
                        if (gp >= wLevel)
                        {
                            gp -= wLevel;
                            wMade++;
                            weapons++;
                            //vqueue - made a weapon!
                            VQueue.queue(2, 0);
                        }
                        else
                        {
                            //vqueue - tried to make a weapon, but not enough gold to buy ingredients!
                            VQueue.queue(3, 0);
                            break;
                        }
                    }
                }
                if (sGuy != "")
                {
                    int tryMake = r.Next(1, sLevel + 3);
                    for (int i = 0; i < tryMake; i++)
                    {
                        if (gp >= sLevel)
                        {
                            gp -= sLevel;
                            sMade++;
                            steeds++;
                            //vqueue - made a steed!
                            VQueue.queue(4, 0);
                        }
                        else
                        {
                            //vqueue - tried to make a steed, but not enough gold to buy ingredients!
                            VQueue.queue(5, 0);
                            break;
                        }
                    }
                }

                // making is over!
                VQueue.queue(6, 0); // vqueue -- throw open the doors to customers!

                // generate a number of customers based on total itemry, minimum 3 customers
                int totalItems = potions + weapons + steeds;
                int customers = r.Next(3, totalItems + 3);

                // let each customer have a shot at buying something
                while (totalItems > 0 && customers > 0)
                {
                    // customer rolls to see if they buy an item (66% shot) and then roll to see if you have what they want
                    if (r.Next(1, 100) > 33)
                    {
                        switch (r.Next(0, 3))
                        {
                            case 0:
                                if (potions > 0)
                                {
                                    potions--;
                                    pSold++;
                                    totalItems--;
                                    gp += 2 * pLevel;
                                    //vqueue -- bought potion
                                    VQueue.queue(7, 0);
                                }
                                else
                                {
                                    // vqueue -- no potion, no sale
                                    VQueue.queue(8, 0);
                                }
                                break;
                            case 1:
                                if (weapons > 0)
                                {
                                    weapons--;
                                    wSold++;
                                    totalItems--;
                                    gp += 2 * wLevel;
                                    //vqueue -- bought weapon
                                    VQueue.queue(9, 0);
                                } 
                                else
                                {
                                    // vqueue -- no weapon, no sale
                                    VQueue.queue(10, 0);
                                } break;
                            case 2:
                                if (steeds > 0)
                                {
                                    steeds--;
                                    totalItems--;
                                    sSold++;
                                    gp += 2 * sLevel;
                                    //vqueue -- bought steed
                                    VQueue.queue(11, 0);
                                } 
                                else
                                {
                                    // vqueue -- no steed, no sale
                                    VQueue.queue(12, 0);
                                } break;
                        }
                    }
                    else
                    {
                        // vqueue -- browsing, no sale
                        VQueue.queue(13, 0);
                    }

                    customers--; // handled another customer! ;)
                }

                // vqueue -- end of day reports
                VQueue.queue(14,0);
            }
        }

        static bool isPrime(int num)
        {
        	int count = 2;
        	while(count * 2 <= num)
        	{
        		if(num % count == 0)
        			return false;
        		count++;
        	}
        	return true;
        }
        static void Main(string[] args)
        {
        	// test area for developer mode
        	// what a good place to be!
        	
   			// this test is preserved for posterity because I'm very proud of it. That doesn't indicate it's a good test, btw. Can you figure out the math trick?
   			/*
        	for(int i=0; i<5; i++)
        	{
        		System.Console.Clear();
        		VQueue.showCustomerInteraction(i%2 == 0, i%3);
        		System.Console.ReadKey();
        	} */
        	
       
        	
            // show splash screen
            System.Console.WriteLine("\n\n  retronics proudly presents  \n\n    a game by byron lagrone\n\n\n\n");
            System.Console.WriteLine("    Fantasy Vendor v" + majorversion + "." + minorversion + "\n\n  your chance to literally run the store\n\n\nPress a key to continue...");
            System.Console.ReadKey();
            System.Console.Clear();
            
            // THANK BACKERS from the KICKSTARTER. they were all VERY NICE AS FAR AS I KNOW
            System.Console.WriteLine("\n\n retronics would like to thank the following individuals,\n   groups, corporations, planets and all-around Cool Persons.\n");
            System.Console.WriteLine("\nin no particular order:\n\n\n   Paul Friedman\tDresden260\t  Mike Nutt\n");
            System.Console.WriteLine(" Spencer Stantis' parents\t     Jordan Goldstein\n");
            System.Console.WriteLine("   JC (not Christ)\tValtoro\t\tMattias Hansson\n");
            System.Console.WriteLine(" Rochelle Roberts\tJohn Colagioia\t  Darcy Prior\n");
            System.Console.WriteLine("   HermitFromPluto\tKristen\t\tVan Van Duong\n");
            System.Console.WriteLine(" ~james~\tZhenglong\tLeokatz\t   Miles Matton\n");
            System.Console.WriteLine("      and Joseph, the amazing god of all that is awesome");
            System.Threading.Thread.Sleep(8000);
            System.Console.Clear();
            
            // select mode
            System.Console.WriteLine(" Press [c] to select Challenge Mode or any other key to play Normal Mode.");
            if(System.Console.ReadKey(true).Key == ConsoleKey.C)
            	challengeMode = true;
            System.Console.Clear();

            // name store
            System.Console.WriteLine(" By what name shall your store be called?");
            StoreData.name = System.Console.ReadLine();
            System.Console.Clear();

            // pick a starting employee
            System.Console.WriteLine("You may choose a starting employee from the list:\n 1) Sorcelator\n 2) Calchemist\n 3) Daggerman\n 4) Murdilizer\n 5) Steed-dore\n 6) Horsinator\n");
            System.Console.WriteLine("    Sorcelators and Calchemists brew potions;\n    Daggermans and Murdilizers are weapons sexperts;\n    Steed-dores and Horsinators do unspeakable things with steeds.");
            System.ConsoleKey k;
            bool done = false;
            do
            {
                k = System.Console.ReadKey(true).Key;
                if(k == ConsoleKey.D1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine( " And by what name will your Sorcelator be known?");
                    StoreData.pGuy = System.Console.ReadLine() + " the Sorcelator";
                    done = true;
                }
                if(k == ConsoleKey.D2)
                {
                    System.Console.Clear();
                    System.Console.WriteLine( " And by what name will your Calchemist be known?");
                    StoreData.pGuy = System.Console.ReadLine() + " the Calchemist";
                    done = true;
                }
                if(k == ConsoleKey.D3)
                {
                    System.Console.Clear();
                    System.Console.WriteLine( " And by what name will your Daggerman be known?");
                    StoreData.wGuy = System.Console.ReadLine() + " the Daggerman";
                    done = true;
                }
                if(k == ConsoleKey.D4)
                {
                    System.Console.Clear();
                    System.Console.WriteLine( " And by what name will your Murdilizer be known?");
                    StoreData.wGuy = System.Console.ReadLine() + " the Murdilizer";
                    done = true;
                }
                if(k == ConsoleKey.D5)
                {
                    System.Console.Clear();
                    System.Console.WriteLine( " And by what name will your Steed-dore be known?");
                    StoreData.sGuy = System.Console.ReadLine() + " the Steed-dore";
                    done = true;
                }
                if(k == ConsoleKey.D6)
                {
                    System.Console.Clear();
                    System.Console.WriteLine( " And by what name will your Horsinator be known?");
                    StoreData.sGuy = System.Console.ReadLine() + " the Horsinator";
                    done = true;
                }
            } while (!done);

            done = false;

            // main game loop:
            do
            {
            //  increment the number of days
                StoreData.day++;

            // clear screen and display data
                showStatus();

            // hire a new employee or level up if you've enough money
                if (StoreData.gp >= 10 && (StoreData.wGuy == "" || StoreData.pGuy == "" || StoreData.sGuy == ""))
                {
                    System.Console.WriteLine("Would you like to hire a new employee\n  at a cost of 10 gold(y/n)?");
                    if (System.Console.ReadKey(true).Key == ConsoleKey.Y)
                    {
                        StoreData.gp -= 10;
                        hireNewEmployee();
                    }
                }
                if (StoreData.gp >= 10 + StoreData.leveledUp*10)
                {
                    System.Console.WriteLine("\n\nWould you like to level up a skill\n  at a cost of " + (10 + StoreData.leveledUp * 10) + "(y/n)?");
                    if (System.Console.ReadKey(true).Key == ConsoleKey.Y)
                    {
                        StoreData.gp -= 10 + StoreData.leveledUp * 10;
                        levelUp();
                    }
                }
            
            //  do a random encounter or skip
                showStatus();
                System.Console.WriteLine("\nHow will you spend the morning, before the store opens?\n");
                System.Console.WriteLine("  1) Visit Forest of Perpetual Usefulness\n  2) Traverse the Elemental Plane of Weapons\n  3) Do a Sexy Prance to Attract Steeds\n  4) Visit the Hotel Vagabond\n\n");
                System.Console.WriteLine("    The Forest is generally safe;\n    The Elemental Planes are sometimes dangerous;\n    Prancing can ruin your financial health;\n    The Hotel Vagabond is always safe. Just like in real life.");
                bool ddone = false;
                do
                {
                	k = System.Console.ReadKey(true).Key;
                    if (k == ConsoleKey.D1)
                    {
                        System.Console.Clear();
                        doEncounter(0);
                        ddone = true;
                    }
                    if (k == ConsoleKey.D2)
                    {
                        System.Console.Clear();
                        doEncounter(1);
                        StoreData.wLevel++;
                        ddone = true;
                    }
                    if (k == ConsoleKey.D3)
                    {
                        System.Console.Clear();
                        doEncounter(2);
                        ddone = true;
                    }
                    if (k == ConsoleKey.D4)
                    {
                        System.Console.Clear();
                        doEncounter(3);
                        ddone = true;
                    }
                } while (!ddone);

            //  do a day
                StoreData.generateStoreDay();
            
            //  do rent for the day, if we selected Challenge mode.
            if(challengeMode)
            {
            	StoreData.gp -= StoreData.day;
            	showStatus();
            	System.Console.WriteLine("\n  You paid " + StoreData.day + " gold in rent and taxes today.");
            	System.Console.WriteLine("\n   Press any key to continue...");
            	System.Console.ReadKey(true);
            }

            // check to see if game is over
                if (StoreData.gp <= 0)
                    done = true;
            } while(!done);

            System.Console.Clear();
            System.Console.WriteLine("\n You ran out of gold at the end of the day! You're bankrupt.\n :(\n\n\n  GAME OVER \n\nYou lasted " + StoreData.day + " days,\nand had the following items left in stock:\n" + StoreData.potions + " potions, " + StoreData.weapons + " weapons, and " + StoreData.steeds + " steeds.");
            System.Console.WriteLine("\n\n Thanks for playing! ");
            System.Console.ReadKey(true);
        }

        public static void showStatus()
        {
            System.Console.Clear();
            System.Console.WriteLine(StoreData.name + "\t Day " + StoreData.day + "\t " + StoreData.gp + " gp\n");
            System.Console.Write(" stock: ");
            if (StoreData.pGuy != "")
                System.Console.Write(StoreData.potions + " potions   ");
            if (StoreData.wGuy != "")
                System.Console.Write(StoreData.weapons + " weapons   ");
            if (StoreData.sGuy != "")
                System.Console.Write(StoreData.steeds + " steeds   ");
            System.Console.WriteLine("\n");
        }

        public static void levelUp()
        {
            System.Console.WriteLine("You may level up:\n");
            if (StoreData.pGuy != "")
                System.Console.WriteLine(" 1) Potion-brewery");
            if (StoreData.wGuy != "")
                System.Console.WriteLine(" 2) Weaponcrafty");
            if (StoreData.sGuy != "")
                System.Console.WriteLine(" 3) Steed-subduin'");
            System.Console.WriteLine("\n\n    Leveled up items cost more to make but sell for substantially more gold.");
            System.ConsoleKey k;
            bool done = false;
            do
            {
                k = System.Console.ReadKey(true).Key;
                if (k == ConsoleKey.D1 && StoreData.pGuy != "")
                {
                    System.Console.Clear();
                    StoreData.pLevel++;
                    done = true;
                }
                if (k == ConsoleKey.D2 && StoreData.wGuy != "")
                {
                    System.Console.Clear();
                    StoreData.wLevel++;
                    done = true;
                }
                if (k == ConsoleKey.D3 && StoreData.sGuy != "")
                {
                    System.Console.Clear();
                    StoreData.sLevel++;
                    done = true;
                }
            } while (!done);
            StoreData.leveledUp++;
        }

        public static void hireNewEmployee()
        {
        	System.Console.Clear();
            // pick a new employee
            System.Console.WriteLine("You may hire an additional employee from the list:\n 1) Sorcelator\n 2) Calchemist\n 3) Daggerman\n 4) Murdilizer\n 5) Steed-dore\n 6) Horsinator\n");
            System.Console.WriteLine("    If you hire someone in a category you already have,\n    the new hire will replace the old.\n\n    Sorcelators and Calchemists brew potions;\n    Daggermans and Murdilizers are weapons sexperts;\n    Steed-dores and Horsinators do unspeakable things with steeds.");
            System.ConsoleKey k;
            bool done = false;
            do
            {
                k = System.Console.ReadKey(true).Key;
                if (k == ConsoleKey.D1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine(" And by what name will your Sorcelator be known?");
                    StoreData.pGuy = System.Console.ReadLine() + " the Sorcelator";
                    done = true;
                }
                if (k == ConsoleKey.D2)
                {
                    System.Console.Clear();
                    System.Console.WriteLine(" And by what name will your Calchemist be known?");
                    StoreData.pGuy = System.Console.ReadLine() + " the Calchemist";
                    done = true;
                }
                if (k == ConsoleKey.D3)
                {
                    System.Console.Clear();
                    System.Console.WriteLine(" And by what name will your Daggerman be known?");
                    StoreData.wGuy = System.Console.ReadLine() + " the Daggerman";
                    done = true;
                }
                if (k == ConsoleKey.D4)
                {
                    System.Console.Clear();
                    System.Console.WriteLine(" And by what name will your Murdilizer be known?");
                    StoreData.wGuy = System.Console.ReadLine() + " the Murdilizer";
                    done = true;
                }
                if (k == ConsoleKey.D5)
                {
                    System.Console.Clear();
                    System.Console.WriteLine(" And by what name will your Steed-dore be known?");
                    StoreData.sGuy = System.Console.ReadLine() + " the Steed-dore";
                    done = true;
                }
                if (k == ConsoleKey.D6)
                {
                    System.Console.Clear();
                    System.Console.WriteLine(" And by what name will your Horsinator be known?");
                    StoreData.sGuy = System.Console.ReadLine() + " the Horsinator";
                    done = true;
                }
            } while (!done);
        }

        public static void doEncounter(int num)
        {
            showStatus();

            int d = StoreData.r.Next(1, 100);
            switch (num)
            {
                case 0: // the Forest of Perpetual Usefulness
                    {
                        if (d < 50)
                        {
                            System.Console.WriteLine("Ho, what luck!\n  You rob a ho for luck.\n    You find some gold.");
                            StoreData.gp += StoreData.r.Next(4, 14);
                        }
                        else
                            System.Console.WriteLine(" You enjoy a pleasant stroll in the woods,\n  interrupted only by a bout of perverse violence.");
                    } break;
                case 1: // the Elemental Plane of Weapons
                    {
                        if (d < 20)
                        {
                            System.Console.WriteLine("You are sliced to ribbons by the weapons.\n  You get better.\n");
                        }
                        else if (d < 50)
                        {
                            System.Console.WriteLine("What the hell is an air elemental doing here?\n  You get the out of there, sharpish.\n");
                        }
                        else if (d < 90)
                        {
                            System.Console.WriteLine("There's a large stack of PlayBlade magazines under the rocks.\n  Wisely, you steer clear.\n");
                        }
                        else
                        {
                            System.Console.WriteLine("A blade elemental buys the shirt off your back.\n  Clothes are a rare commodity in the plane of elemental weaponry,\n    and he compensates you well.");
                            StoreData.gp += StoreData.r.Next(15, 30);
                        }
                    } break;
                case 2: // Sexy Prance!
                    {
                        System.Console.WriteLine("Sadly, none but the king would find your sexy\n  prancing worthy of reward.");
                        if (d > 96)
                        {
                            System.Console.WriteLine("    And today the King himself has shown up! He lavishes you with jewels.\n      This makes all the prior humiliation worth it!\n        Almost.");
                        }
                    } break;
                case 3: // A wasted morning... UNLESS YOU LIKE BEER. YAY BEER!
                    {
                        System.Console.WriteLine("You spend your morning the traditional way.\n  Awash in ale, card games and ale-covered card games.\n    It's all a marvelous blur.");
                    } break;
                default: System.Console.WriteLine(".error. You somehow had an invalid encounter.\n  I'm terribly sorry. Nothing happens. :(");
                    break;
            }
            System.Console.ReadKey(true);
        }
    }
}
