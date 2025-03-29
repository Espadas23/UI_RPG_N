# UI_RPG_N


Setter.(Inkapsulacija)
1. GameManager.cs
2. player.ActiveWeapon = availableWeapons[randomIndex];
3. Izmantojam setter lai izveidotu iero?u sarakstu, un p?c tam izsaukt to.
4. Mums ar? ir setter Character.cs, es to apvienoju ar getter. M?s p?rliecin?mies, ka jaunais ierocis noteikti ir pa?emts.


Papildu uzdevums. 3 iero?u tipi, starp ko sp?l?t?js var izv?l?ties.
1. Es papildus izveidoju v?l 2 skripti – IcyWeapon.cs un FireWeapon.cs
2. PoisonWeapon mums jau ir izveidots.
3. Ar? pats ierocis tiek iestat?ts, izmantojot Setter (Character.cs).
4. Vispirms m?s izveidojam iero?u sarakstu, no kura tos atlas?sim.
5. [SerializeField] private List<Weapon> availableWeapons;
6. Mums ir j?atjaunina public void DoRound()- ChangePlayerWeapon();
7. Izveidojam jaunu metodi - private void ChangePlayerWeapon()
8. M?su manipul?ciju rezult?t? sp?l?t?js katru g?jienu izv?las jaunu ieroci.

Ar? visi m?su izveidotie papildu iero?i izmanto OOP (Mantošanu)
no Weapon.cs


