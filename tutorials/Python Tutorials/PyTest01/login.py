import test as t
from simple_salesforce import Salesforce


sf = Salesforce(instance_url=t.instance, username=t.user,
                password=t.password, security_token=t.token,
                sandbox=t.isSandbox)

sf.query_all('SELECT Id, Name, Phone FROM Account LIMIT 100')
