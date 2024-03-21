Problem statement -
We have lagacy system that communicates with a database using an outdated interface, called as 'ILegacyDatabase'.
However we want to upgrade our system to use a modern database library that provides a different interface, say 'IModernDatabase'.

Solution statement - 
TO bridge gap between the old and new interfaces, we can create Adapter class, lets call it as 'DatabaseAdapter', 
that implements 'IModernDatabase' interface but internally delegate call to the method of ILegacyDatabase interface.

This way, your new system can seamlessly interact with the old database without needing to modify the existing code.